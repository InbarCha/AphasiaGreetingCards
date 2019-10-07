using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AphasiaGreetingCards.Models
{
    public class GreetingCard
    {
        public int ID { get; set; }

        [Display(Name = "Theme")]
        public string theme { get; set; }

        [Display(Name = "Sender ID")]
        public int sendertUserID { get; set; }

        [Display(Name = "Sender")]
        public string senderUserFullName { get; set; }

        [Display(Name = "Recipient ID")]
        public int recipientUserID { get; set; }

        [Display(Name = "Recipient")]
        public string recipientUserFullName { get; set; }

        [Display(Name = "Sentence ID")]
        public int sentenceID { get; set; }

        [Display(Name = "Sentence")]
        public string fullSentence { get; set; }

        [Display(Name = "Image")]
        public int imageID { get; set; }

        [Display(Name = "Image")]
        public string image { get; set; }

        [Display(Name = "Published To Facebook?")]
        public bool publishedToFacebook { get; set; }
    }
}
