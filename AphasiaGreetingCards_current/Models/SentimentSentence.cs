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

        [Required]
        [Display(Name = "Theme")]
        public string theme { get; set; }

        [Required]
        [Display(Name = "Prefix")]
        public string prefix { get; set; }

        public int recipientUserID { get; set; }

        [Required]
        [Display(Name = "Recipient")]
        public string recipientUserFirstName { get; set; }

        [Required]
        [Display(Name = "Suffix")]
        public string suffix { get; set; }

        [Required]
        [Display(Name = "Complexity")]
        public string complexity { get; set; } //high or low
    }
}
