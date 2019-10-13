using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AphasiaGreetingCards.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AphasiaGreetingCards.Data;

namespace AphasiaGreetingCards.Controllers
{
    public class SentimentSentencesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SentimentSentencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SentimentSentences
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.SentimentSentences.ToListAsync());
        }

        // GET: SentimentSentences/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sentimentSentence = await _context.SentimentSentences
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sentimentSentence == null)
            {
                return NotFound();
            }

            return View(sentimentSentence);
        }

        // GET: SentimentSentences/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SentimentSentences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind(("ID,theme,prefix,recipientUserEmail,suffix,complexity"))] SentimentSentence sentimentSentence)
        {
            if (ModelState.IsValid)
            {
                var recipientUser = _context.Users.FirstOrDefaultAsync(m => m.Email == sentimentSentence.recipientUserEmail).Result;
                if (recipientUser != default)
                {
                    var recipientUserFirstName = recipientUser.FirstName;
                    sentimentSentence.recipientUserFirstName = recipientUserFirstName;
                }
                else
                { 
                    sentimentSentence.recipientUserFirstName = sentimentSentence.recipientUserEmail;
                    sentimentSentence.recipientUserEmail = "Default@default.com" ;
                }

                _context.Add(sentimentSentence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sentimentSentence);
        }

        // GET: SentimentSentences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sentimentSentence = await _context.SentimentSentences.FindAsync(id);
            if (sentimentSentence == null)
            {
                return NotFound();
            }
            return View(sentimentSentence);
        }

        // POST: SentimentSentences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,theme,prefix,recipientUserEmail,recipientUserFirstName,suffix,complexity")] SentimentSentence sentimentSentence)
        {
            if (id != sentimentSentence.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var recipientUser = _context.Users.FirstOrDefaultAsync(m => m.Email == sentimentSentence.recipientUserEmail).Result;
                    if (recipientUser != default)
                    {
                        var recipientUserFirstName = recipientUser.FirstName;
                        sentimentSentence.recipientUserFirstName = recipientUserFirstName;
                    }
                    else
                    {
                        sentimentSentence.recipientUserFirstName = sentimentSentence.recipientUserEmail;
                        sentimentSentence.recipientUserEmail = "Default@default.com";
                    }

                    _context.Update(sentimentSentence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SentimentSentenceExists(sentimentSentence.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sentimentSentence);
        }

        // GET: SentimentSentences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sentimentSentence = await _context.SentimentSentences
                .FirstOrDefaultAsync(m => m.ID == id);
            if (sentimentSentence == null)
            {
                return NotFound();
            }

            return View(sentimentSentence);
        }

        // POST: SentimentSentences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sentimentSentence = await _context.SentimentSentences.FindAsync(id);
            _context.SentimentSentences.Remove(sentimentSentence);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SentimentSentenceExists(int id)
        {
            return _context.SentimentSentences.Any(e => e.ID == id);
        }
    }
}
