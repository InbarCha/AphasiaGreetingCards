

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
            CountUsers();
            return View();
        }
        private void CountUsers()
        {
            ViewBag.numOfUsers = _context.Users.ToList().Count();
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
                    if (_context.GreetingCards.Where(n => n.recipientUserFullName.ToLower().Contains(ss.ToLower())).Count() > 0)
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
    }
}
