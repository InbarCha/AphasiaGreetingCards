using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AphasiaGreetingCards.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AphasiaGreetingCards.Data;
using Accord.MachineLearning;
using System;
using System.Net.Http;

namespace AphasiaGreetingCards.Controllers
{
    public class GreetingCardsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly string FacebookPageAccessToken = "EAAH4sfKIrl4BAKZBOtDTSwAsbCjrbkwuvvTikJPFSmRZCV54vEkC4tmgqbREzIUlZAKjryPgOiZAsrSnDIN8cpFjSS95mGwn1xwB13ZBzvvGHJiTF0vTRSCEkWufm4ARl5ZBQEuTdHEsiKFXqrpnagJRrcvaom76BkrtZA06MWstnkmuvuwakwkK6kZC3RjRl5gZD";
        private static readonly HttpClient client = new HttpClient();

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
                List<GreetingCard> greetingCardEnumerable = new List<GreetingCard>();
                greetingCardEnumerable.Add(greetingCard);
                return View(greetingCardEnumerable);
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
           
            //------------SUGGEST A GREETING CARD--------------------------
            //if there are enough users for K-Means, find a greeting card for suggestion
            if(_context.Users.Count() >= 10)
            {
                //find the logged in user
                var email = User.Identity.Name;
                User loggedInUser = _context.Users.FirstOrDefault(u => u.Email == email);

                //----------- K MEANS (in our case 9-means) --------------------
                List<double[]> observations = kMeansGetObservations();
                //array's size is the number of observations, containing the label for each observation (in the observations' order)
                int[] labels = clusterKMeans(observations.ToArray());
                
                int userIndex = FindUserIndexInDb(loggedInUser);
                if (userIndex == -1)
                    return View(model);
                else
                {
                    //get the user's label
                    int userLabel = labels[userIndex];

                    //find whether another user with the same label exists
                    int userFromTheSameLabelIndex = -1;
                    for (int i = 0; i<labels.Length; i++)
                    {
                        if (labels[i] == userLabel)
                            userFromTheSameLabelIndex = i;
                    }

                    //there isn't another user from the same label
                    if (userFromTheSameLabelIndex == -1)
                    {
                        return View(model);
                    }
                    //there exists another user from the same label
                    else
                    {
                        User userFromTheSameLabel = _context.Users.ToArray()[userFromTheSameLabelIndex];

                        //find all greeting cards that the other user created
                        List<GreetingCard> otherUserGreetingCards = new List<GreetingCard>();
                        foreach (GreetingCard g in _context.GreetingCards)
                        {
                            if (g.sendertUserEmail == userFromTheSameLabel.Email)
                            {
                                otherUserGreetingCards.Add(g);
                            }
                        }

                        //the other user (from the same label) created some greeting card
                        //choose one at random and return it to the view
                        if (otherUserGreetingCards.Any())
                        {
                            Random r = new Random();
                            int random = r.Next(0, otherUserGreetingCards.Count());

                            GreetingCard toReturn = otherUserGreetingCards.ToArray()[random];
                            toReturn.ImagesDB = _context.Images;
                            toReturn.SentimentSentencesDB = _context.SentimentSentences;

                            return View(toReturn);
                        }
                    }
                }
                return View(model);
            }
            else
            {
                return View(model);
            }
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
                if(greetingCard.publishedToFacebook)
                {
                    await postToFacebook(greetingCard.senderUserFullName, greetingCard.sentencePrefix, greetingCard.recipientUserFullName, greetingCard.sentenceSuffix);
                }
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

        //GROUP BY
        public async Task<IActionResult> CountGreetingCardsPerTheme()
        {
            var selectedGreetingCards = from g in _context.GreetingCards
                                        group g by g.theme;

            if(selectedGreetingCards.Any())
            {
                Dictionary<string, int> greetingCardPerThemeCnt = new Dictionary<string, int>();
                foreach(IGrouping<string, GreetingCard> c in selectedGreetingCards)
                {
                    greetingCardPerThemeCnt.Add(c.Key, c.Count(g=>g.theme == c.First().theme));
                }
                _context.GreetingCards.First().groupByPerTheme = greetingCardPerThemeCnt;
                _context.GreetingCards.First().ImagesDB = _context.Images;
                return View("Index", await _context.GreetingCards.ToListAsync());
            }
            else
            {
                GreetingCard greetingCard = new GreetingCard { ImagesDB = _context.Images };
                List<GreetingCard> greetingCardEnumerable = new List<GreetingCard>();
                greetingCardEnumerable.Add(greetingCard);
                
                return View("Index", greetingCardEnumerable);
            }
        }

        //join 1
        public IActionResult WithImageResolution()
        {
            var selectedGreetingCards = from g in _context.GreetingCards
                                        join image in _context.Images on g.imageID equals image.ID
                                        select new { g, image };

            if (selectedGreetingCards.Any())
            {
                List<GreetingCard> greetingCards = new List<GreetingCard>();
                greetingCards.AddRange(_context.GreetingCards);

                int numberOfItems = selectedGreetingCards.Count();
                for(int i = 0; i < numberOfItems; i++)
                {
                    string resolution = selectedGreetingCards.ToArray()[i].image.resolution;
                    greetingCards.ElementAt(i).imageResolution = resolution;
                }

                _context.GreetingCards.First().ImagesDB = _context.Images;
                return View(greetingCards);
            }
            else
            {
                GreetingCard greetingCard = new GreetingCard { ImagesDB = _context.Images };
                List<GreetingCard> greetingCardEnumerable = new List<GreetingCard>();
                greetingCardEnumerable.Add(greetingCard);

                return View("Index", greetingCardEnumerable);
            }
        }

        //join 2
        public IActionResult WithImageDigitalSize()
        {
            var selectedGreetingCards = from g in _context.GreetingCards
                                        join image in _context.Images on g.imageID equals image.ID
                                        select new { g, image };

            if (selectedGreetingCards.Any())
            {
                List<GreetingCard> greetingCards = new List<GreetingCard>();
                greetingCards.AddRange(_context.GreetingCards);

                int numberOfItems = selectedGreetingCards.Count();
                for(int i = 0; i < numberOfItems; i++)
                {
                    int digitalSize = selectedGreetingCards.ToArray()[i].image.digitalSize;
                    greetingCards.ElementAt(i).imageDigitalSize = digitalSize;
                }

                _context.GreetingCards.First().ImagesDB = _context.Images;
                return View(greetingCards);
            }
            else
            {
                GreetingCard greetingCard = new GreetingCard { ImagesDB = _context.Images };
                List<GreetingCard> greetingCardEnumerable = new List<GreetingCard>();
                greetingCardEnumerable.Add(greetingCard);

                return View("Index", greetingCardEnumerable);
            }
        }

        private List<double[]> kMeansGetObservations()
        {
            List<double[]> observations = new List<double[]>();

            /* 
            for every user, iterate over every greeting card
            if the greeting card was sent by the user, 
            check the greeting card's theme and update the userThemeCount accordingly
            */
            foreach (User u in _context.Users)
            {
                double[] userThemeCount = new double[9];
                foreach (GreetingCard g in _context.GreetingCards)
                {
                    if (g.sendertUserEmail == u.Email)
                    {
                        switch (g.theme)
                        {
                            case "Birthday":
                                {
                                    userThemeCount[0]++;
                                    break;
                                }
                            case "Bar Mitzva":
                                {
                                    userThemeCount[1]++;
                                    break;
                                }
                            case "It's a boy!":
                                {
                                    userThemeCount[2]++;
                                    break;
                                }
                            case "Daily":
                                {
                                    userThemeCount[3]++;
                                    break;
                                }
                            case "It's a girl!":
                                {
                                    userThemeCount[4]++;
                                    break;
                                }
                            case "Holiday":
                                {
                                    userThemeCount[5]++;
                                    break;
                                }
                            case "Love":
                                {
                                    userThemeCount[6]++;
                                    break;
                                }
                            case "Valentine":
                                {
                                    userThemeCount[7]++;
                                    break;
                                }
                            case "Wedding":
                                {
                                    userThemeCount[8]++;
                                    break;
                                }
                        }
                    }
                }
                observations.Add(userThemeCount);
            }

            return observations;
        }

        private int[] clusterKMeans(double[][] observations)
        {
            Accord.Math.Random.Generator.Seed = 0;
            KMeans kmeans = new KMeans(9);
            KMeansClusterCollection clusters = kmeans.Learn(observations);
            int[] labels = clusters.Decide(observations);

            return labels;
        }

        private int FindUserIndexInDb(User user)
        {
            for(int i=0; i<_context.Users.Count(); i++)
            {
                if (_context.Users.ToArray()[i].Email == user.Email)
                    return i;
            }

            return -1;
        }

        private async Task<bool> postToFacebook(string senderUserFullName, string prefix, string recipientUserFullName, string suffix)
        {
            var values = new Dictionary<string, string>
            {
                { "message", "User " + senderUserFullName + " sent a greeting card: " +  prefix + ", " + recipientUserFullName + "! " + suffix },
            };

            string url = "https://graph.facebook.com/100564308037278/feed" + "?access_token=" + FacebookPageAccessToken;
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync(url, content);

            return false;
        }
    }
}
