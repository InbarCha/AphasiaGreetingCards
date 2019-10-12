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
            var all = _context.GreetingCards.ToList();
            string[] strings = new string[all.Count];
            for (int i = 0; i < all.Count; i++)
            {
                strings[i] = all.ElementAt(i).fullSentence;
            }
            ViewData["Strings"] = strings;
            ViewBag.StringsCount = all.Count;
            return View();
        }
        private Dictionary<string,int> CountWords()
        {


            return null;
        }
    }
}