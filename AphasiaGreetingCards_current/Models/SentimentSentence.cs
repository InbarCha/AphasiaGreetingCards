using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AphasiaGreetingCards.Models
{
    public class SentimentSentence
    {
        public int ID { get; set; }

        [Display(Name = "Theme")]
        public string theme { get; set; }

        [Display(Name = "Prefix")]
        public string prefix { get; set; }

        public int recipientUserID { get; set; }

        [Display(Name = "Recipient")]
        public string recipientUserFirstName { get; set; }

        [Display(Name = "Suffix")]
        public string suffix { get; set; }

        [Display(Name = "Complexity")]
        public string complexity { get; set; } //high or low
    }
}
