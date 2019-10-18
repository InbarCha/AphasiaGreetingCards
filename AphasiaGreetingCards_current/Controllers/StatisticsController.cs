using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AphasiaGreetingCards.Data;
using AphasiaGreetingCards.Models;
using Microsoft.AspNetCore.Mvc;

namespace AphasiaGreetingCards.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StatisticsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Dictionary<string, int> map = CountWords();
            string[] keys = new string[map.Count];
            int[] vals = new int[map.Count];
            int i = 0;
            foreach (var item in map)
            {
                keys[i] = item.Key;
                vals[i++] = item.Value;
            }
            ViewData["keys"] = keys;
            ViewData["vals"] = vals;
            ViewBag.StringsCount = keys.Count();
            var types = _context.GreetingCards.Select(n => n.theme).Distinct().ToList();
            string[] names = new string[types.Count()];
            int[] quan = new int[types.Count()];
            for (int j = 0; j < types.Count(); j++)
            {
                names[j] = types.ElementAt(j).ToString();
                quan[j] = _context.GreetingCards.Where(n => n.theme.Equals(names[j])).Count();
            }
            ViewData["names"] = names;
            ViewData["quan"] = quan;
            return View();
        }
        private Dictionary<string, int> CountWords()
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            var sentences = _context.GreetingCards.Select(p => p.fullSentence).ToArray();
            foreach (var s in sentences)
            {
                var punctuation = s.Where(Char.IsPunctuation).Distinct().ToArray();
                var words = s.Split().Select(x => x.Trim(punctuation));
                foreach (var ss in words)
                {
                    if (_context.Users.Where(n=>n.FirstName.ToLower().Equals(ss.ToLower())).Count() > 0)
                    {
                        continue;
                    }
                    if (map.ContainsKey(ss))
                    {
                        map[ss]++;
                    }
                    else
                    {
                        map.Add(ss, 1);
                    }
                }
            }
            return map;
        }
        public PartialViewResult CountTypes()
        {
            var types = _context.GreetingCards.Select(n => n.theme).Distinct();
            string[] names = new string[types.Count()];
            int[] quan = new int[types.Count()];
            for(int i = 0; i < types.Count(); i++)
            {
                names[i] = types.ElementAt(i);
                quan[i] = _context.GreetingCards.Where(n => n.theme.Equals(names[i])).Count();
            }
            ViewData["names"] = names;
            ViewData["quan"] = quan;
            return PartialView("Pie", null);
        }
    }
}