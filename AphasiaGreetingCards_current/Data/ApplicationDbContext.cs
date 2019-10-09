using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AphasiaGreetingCards.Models;
using Microsoft.AspNetCore.Identity;

namespace AphasiaGreetingCards.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AphasiaGreetingCards.Models.GreetingCard> GreetingCards { get; set; }
        public DbSet<AphasiaGreetingCards.Models.Image> Images { get; set; }
        public DbSet<AphasiaGreetingCards.Models.SentimentSentence> SentimentSentences { get; set; }

    }
}
