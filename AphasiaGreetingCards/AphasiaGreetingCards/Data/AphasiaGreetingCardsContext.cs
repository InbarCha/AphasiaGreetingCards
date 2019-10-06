using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AphasiaGreetingCards.Models
{
    public class AphasiaGreetingCardsContext : DbContext
    {
        public AphasiaGreetingCardsContext (DbContextOptions<AphasiaGreetingCardsContext> options)
            : base(options)
        {
        }

        public DbSet<GreetingCard> GreetingCards { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<SentimentSentence> SentimentSentences { get; set; }
    }
}
