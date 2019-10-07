using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AphasiaGreetingCards.Models;

namespace AphasiaGreetingCards.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GreetingCards()
        {
            ViewData["Message"] = "Specialized Greeting Cards";

            return View();
        }

        public IActionResult SentimentSentences()
        {
            ViewData["Message"] = "Specialized Sentiment Sentences";

            return View();
        }

        public IActionResult CardAdder()
        {
            ViewData["Message"] = "Add a greeting card";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}