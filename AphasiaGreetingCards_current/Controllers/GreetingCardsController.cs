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

using Microsoft.AspNetCore.Identity;


namespace AphasiaGreetingCards.Controllers
{
    public class GreetingCardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GreetingCardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GreetingCards
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            if (_context.GreetingCards.Any())
            {
                _context.GreetingCards.First().ImagesDB = _context.Images;
                return View(await _context.GreetingCards.ToListAsync());
            }
            else
            {
                GreetingCard greetingCard = new GreetingCard { ImagesDB = _context.Images };
                return View(greetingCard);
            }
                
        }

        // GET: GreetingCards/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var greetingCard = await _context.GreetingCards
                .FirstOrDefaultAsync(m => m.ID == id);
            if (greetingCard == null)
            {
                return NotFound();
            }

            return View(greetingCard);
        }

        // GET: GreetingCards/Create
        public IActionResult Create()
        {
            var model = new GreetingCard { SentimentSentencesDB = _context.SentimentSentences, ImagesDB = _context.Images };
            return View(model);
        }

        // POST: GreetingCards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind(("ID,theme,sendertUserEmail,senderUserFullName,recipientUserEmail,sentencePrefix,fullSentence,sentenceSuffix,image,publishedToFacebook"))] GreetingCard greetingCard)
        {
            if (ModelState.IsValid)
            {
                var recipientUser = _context.Users.FirstOrDefaultAsync(m => m.Email == greetingCard.recipientUserEmail).Result;
                if (recipientUser != default)
                {
                    var recipientUserFirstName = recipientUser.FirstName;
                    var recipientUserLastName = recipientUser.LastName;
                    greetingCard.recipientUserFullName = recipientUserFirstName + " " + recipientUserLastName;
                    greetingCard.fullSentence = greetingCard.sentencePrefix + ", " + recipientUserFirstName + "! " + greetingCard.sentenceSuffix;
                }
                else
                {
                    greetingCard.recipientUserFullName = greetingCard.recipientUserEmail;
                    greetingCard.recipientUserEmail = "Default@default.com";
                    greetingCard.fullSentence = greetingCard.sentencePrefix + ", " + greetingCard.recipientUserFullName + "! " + greetingCard.sentenceSuffix;
                }

                Image selectedImage = _context.Images.FirstOrDefaultAsync(m => m.imageName == greetingCard.image).Result;
                if (selectedImage != default)
                {
                    greetingCard.image = selectedImage.imagePath;
                    greetingCard.imageID = selectedImage.ID;
                    greetingCard.imageName = selectedImage.imageName;
                }

                var sentence = _context.SentimentSentences.FirstOrDefaultAsync(m => m.prefix == greetingCard.sentencePrefix && m.suffix == greetingCard.sentenceSuffix).Result;
                if(sentence == default)
                {
                    var sentenceBySuffix = _context.SentimentSentences.FirstOrDefaultAsync(m => m.suffix == greetingCard.sentenceSuffix).Result;
                    if(sentenceBySuffix != default)
                    {
                        var newSentenceToDB = new SentimentSentence { prefix = greetingCard.sentencePrefix, suffix = greetingCard.sentenceSuffix, complexity=sentenceBySuffix.complexity,
                            recipientUserEmail=greetingCard.recipientUserEmail, recipientUserFirstName=greetingCard.recipientUserFullName, theme=greetingCard.theme };
                        _context.SentimentSentences.Add(newSentenceToDB);
                    }
                }

                _context.Add(greetingCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            greetingCard.ImagesDB = _context.Images;
            greetingCard.SentimentSentencesDB = _context.SentimentSentences;
            return View(greetingCard);
        }

        // GET: GreetingCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var greetingCard = await _context.GreetingCards.FindAsync(id);
            if (greetingCard == null)
            {
                return NotFound();
            }

            greetingCard.ImagesDB = _context.Images;
            greetingCard.SentimentSentencesDB = _context.SentimentSentences;
            return View(greetingCard);
        }

        // POST: GreetingCards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("ID,theme,sendertUserEmail,senderUserFullName,recipientUserEmail,sentencePrefix,fullSentence,sentenceSuffix,image,publishedToFacebook")] GreetingCard greetingCard)
        {
            if (id != greetingCard.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var recipientUser = _context.Users.FirstOrDefaultAsync(m => m.Email == greetingCard.recipientUserEmail).Result;
                    if (recipientUser != default)
                    {
                        var recipientUserFirstName = recipientUser.FirstName;
                        var recipientUserLastName = recipientUser.LastName;
                        greetingCard.recipientUserFullName = recipientUserFirstName + " " + recipientUserLastName;
                        greetingCard.fullSentence = greetingCard.sentencePrefix + ", " + recipientUserFirstName + "! " + greetingCard.sentenceSuffix;
                    }
                    else
                    {
                        greetingCard.recipientUserFullName = greetingCard.recipientUserEmail;
                        greetingCard.recipientUserEmail = "Default@default.com";
                        greetingCard.fullSentence = greetingCard.sentencePrefix + ", " + greetingCard.recipientUserFullName + "! " + greetingCard.sentenceSuffix;
                    }

                    Image selectedImage = _context.Images.FirstOrDefaultAsync(m => m.imageName == greetingCard.image).Result;
                    if (selectedImage != default)
                    {
                        greetingCard.image = selectedImage.imagePath;
                        greetingCard.imageID = selectedImage.ID;
                        greetingCard.imageName = selectedImage.imageName;
                    }

                    var sentence = _context.SentimentSentences.FirstOrDefaultAsync(m => m.prefix == greetingCard.sentencePrefix && m.suffix == greetingCard.sentenceSuffix).Result;
                    if (sentence == default)
                    {
                        var sentenceBySuffix = _context.SentimentSentences.FirstOrDefaultAsync(m => m.suffix == greetingCard.sentenceSuffix).Result;
                        if (sentenceBySuffix != default)
                        {
                            var newSentenceToDB = new SentimentSentence
                            {
                                prefix = greetingCard.sentencePrefix,
                                suffix = greetingCard.sentenceSuffix,
                                complexity = sentenceBySuffix.complexity,
                                recipientUserEmail = greetingCard.recipientUserEmail,
                                recipientUserFirstName = greetingCard.recipientUserFullName,
                                theme = greetingCard.theme
                            };
                            _context.SentimentSentences.Add(newSentenceToDB);
                        }
                    }

                    _context.Update(greetingCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GreetingCardsExists(greetingCard.ID))
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
            return View(greetingCard);
        }

        // GET: GreetingCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var greetingCard = await _context.GreetingCards
                .FirstOrDefaultAsync(m => m.ID == id);
            if (greetingCard == null)
            {
                return NotFound();
            }

            return View(greetingCard);
        }

        // POST: GreetingCards/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var greetingCard = await _context.GreetingCards.FindAsync(id);
            _context.GreetingCards.Remove(greetingCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GreetingCardsExists(int id)
        {
            return _context.GreetingCards.Any(e => e.ID == id);
        }

        public async Task<IActionResult> Search(string theme, string fullSentence, string image)
        {
            var selectedGreetingCards = from g in _context.GreetingCards
                                        select g;

            //all three search parameters were given
            if (!string.IsNullOrEmpty(theme) && !string.IsNullOrEmpty(fullSentence) && !string.IsNullOrEmpty(theme))
            {
                selectedGreetingCards = selectedGreetingCards.Where(g => g.theme == theme && g.fullSentence == fullSentence
                                                                      && g.imageName==image);
            }

            //only "theme" and "full sentence" were given
            else if (!string.IsNullOrEmpty(theme) && !string.IsNullOrEmpty(fullSentence) && string.IsNullOrEmpty(image))
            {
                selectedGreetingCards = selectedGreetingCards.Where(g => g.theme == theme && g.fullSentence == fullSentence);
            }
            
            //only "theme" and "image" were given
            else if (!string.IsNullOrEmpty(theme) && string.IsNullOrEmpty(fullSentence) && !string.IsNullOrEmpty(image))
            {
                selectedGreetingCards = selectedGreetingCards.Where(g => g.theme == theme && g.imageName == image);
            }

            //only "full sentence" and "image" were given
            else if (string.IsNullOrEmpty(theme) && !string.IsNullOrEmpty(fullSentence) && !string.IsNullOrEmpty(image))
            {
                selectedGreetingCards = selectedGreetingCards.Where(g => g.fullSentence == fullSentence && g.imageName == image);
            }

            //only "full sentence" was given
            else if (string.IsNullOrEmpty(theme) && !string.IsNullOrEmpty(fullSentence) && string.IsNullOrEmpty(image))
            {
                selectedGreetingCards = selectedGreetingCards.Where(g => g.fullSentence == fullSentence);
            }

            //only "theme" was given
            else if (!string.IsNullOrEmpty(theme) && string.IsNullOrEmpty(fullSentence) && string.IsNullOrEmpty(image))
            {
                selectedGreetingCards = selectedGreetingCards.Where(g => g.theme == theme);
            }

            //only "image" was given
            else if (string.IsNullOrEmpty(theme) && string.IsNullOrEmpty(fullSentence) && !string.IsNullOrEmpty(image))
            {
                selectedGreetingCards = selectedGreetingCards.Where(g => g.imageName == image);
            }

            //--------- search returned result ---------------
            if (selectedGreetingCards.Any())
            {
                selectedGreetingCards.First().ImagesDB = _context.Images;
                return View("Index", await selectedGreetingCards.ToListAsync());
            }

            //---------search returns empty--------------------
            else
            {
                GreetingCard greetingCard = new GreetingCard { ImagesDB = _context.Images };
                List<GreetingCard> greetingCardEnumerable = new List<GreetingCard>();
                greetingCardEnumerable.Add(greetingCard);

                return View("Index", greetingCardEnumerable);
            }
        }
    }
}
