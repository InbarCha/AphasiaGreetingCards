using AphasiaGreetingCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AphasiaGreetingCards.Data
{
    public class DbInitializer
    {
        public static void Initialize(AphasiaGreetingCardsContext context)
        {
            //checks if the database exists - if it doesn't, the database will be created
            context.Database.EnsureCreated();

            //if a GreetingCard already exists in the database, do nothing
            if (context.GreetingCards.Any())
            {
                return;
            }

            var Users = new User[]
            {
                new User{ID=313289068, firstName="Inbar" , lastName="Hachmon", age=24, birthdayDate=DateTime.Parse("1995-03-02"), city="Rishon Lezion",
                    isManager =false, username="inbarcha", password="123456" },
                new User{ID=234676891, firstName="Sivan" , lastName="Peer", age=27, birthdayDate=DateTime.Parse("1992-05-02"), city="Ramat Gan",
                    isManager =false, username="sivp", password="1234576" },
                new User{ID=456576891, firstName="Yuval" , lastName="Shapira", age=31, birthdayDate=DateTime.Parse("1988-10-02"), city="Ramat Gan",
                    isManager =false, username="sivp", password="1234576" }
            };
            foreach (User s in Users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();


            var SentimentSentences = new SentimentSentence[]
            {
                new SentimentSentence{prefix="For your birthday", recipientUserID=313289068, recipientUserFullName="Inbar Hachmon", suffix="best of wishes!", complexity="low", theme="Birthday"},
                new SentimentSentence{prefix="Happy Holiday", recipientUserID=234676891, recipientUserFullName="Sivan Peer", suffix="hope you enjoy it immensely!", complexity="low", theme="Holiday"},
                new SentimentSentence{prefix="Happy Birthday", recipientUserID=456576891, recipientUserFullName="Yuval Shapira", suffix="wish you all of the best!", complexity="low", theme="Birthday"}
            };
            foreach (SentimentSentence c in SentimentSentences)
            {
                context.SentimentSentences.Add(c);
            }
            context.SaveChanges();


            var Images = new Image[]
            {
                new Image{theme="Holiday", imagePath="~/images/HappyHoliday.jpg", resolution="low"},
                new Image{theme="Birthday", imagePath="~/images/HappyBirthday.jpg", resolution="high"},
            };
            foreach (Image e in Images)
            {
                context.Images.Add(e);
            }
            context.SaveChanges();


            var GreetingCards = new GreetingCard[]
            {
                new GreetingCard{recipientUserID=313289068, recipientUserFullName="Inbar Hachmon", sendertUserID=234676891, senderUserFullName="Sivan Peer",
                    theme ="Happy Birthday", sentenceID=1, fullSentence="For your birthday, Inbar, best of wishes!", imageID=1, image="~/images/HappyHoliday.jpg", publishedToFacebook=false },
                new GreetingCard{recipientUserID=234676891, recipientUserFullName="Sivan Peer", sendertUserID=313289068, senderUserFullName="Inbar Hachmon", theme="Happy Birthday",
                    sentenceID =2, fullSentence="Happy birthday, Sivan, wish you all of the best!", imageID=2, publishedToFacebook=false }
            };
            foreach (GreetingCard e in GreetingCards)
            {
                context.GreetingCards.Add(e);
            }
            context.SaveChanges();

        }
    }
}
