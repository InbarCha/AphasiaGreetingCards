using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AphasiaGreetingCards.Models
{
    public class GreetingCard
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Theme")]
        public string theme { get; set; }

        [Required]
        [Display(Name = "Sender Email")]
        public string sendertUserEmail { get; set; }

        [Display(Name = "Sender Full Name")]
        public string senderUserFullName { get; set; }

        [Required]
        [Display(Name = "Recipient User")]
        public string recipientUserEmail { get; set; }

        [Display(Name = "Recipient Full Name")]
        public string recipientUserFullName { get; set; }

        [Display(Name = "Sentence ID")]
        public int sentenceID { get; set; }


        [Display(Name = "Sentence Prefix")]
        public string sentencePrefix { get; set; }

        [Display(Name = "Sentence Suffix")]
        public string sentenceSuffix { get; set; }

        [Required]
        [Display(Name = "Full Sentence")]
        public string fullSentence { get; set; }


        [Display(Name = "Image ID")]
        public int imageID { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string image { get; set; } //image path

        [Display(Name = "Image Name")]
        public string imageName { get; set; } 

        [Required]
        [Display(Name = "Publish To Facebook?")]
        public bool publishedToFacebook { get; set; }

        public IQueryable<SentimentSentence> SentimentSentencesDB { get; set; }
        public IQueryable<Image> ImagesDB { get; set; }

        [NotMapped]
        public Dictionary<string, int> groupByPerTheme { get; set; }

        [NotMapped]
        public string imageResolution { get; set; } //for join
        [NotMapped]
        public int imageDigitalSize { get; set; } //for join

        public GreetingCard()
        {
            groupByPerTheme = new Dictionary<string, int>();
        }
    }
}
