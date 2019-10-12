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

        [Required]
        [Display(Name = "Theme")]
        public string theme { get; set; }

        [Required]
        [Display(Name = "Sender ID")]
        public int sendertUserID { get; set; }

        [Required]
        [Display(Name = "Sender Name")]
        public string senderUserFullName { get; set; }

        [Required]
        [Display(Name = "Recipient ID")]
        public int recipientUserID { get; set; }

        [Required]
        [Display(Name = "Recipient Name")]
        public string recipientUserFullName { get; set; }

        [Required]
        [Display(Name = "Sentence ID")]
        public int sentenceID { get; set; }

        [Required]
        [Display(Name = "Sentence")]
        public string fullSentence { get; set; }

        [Required]
        [Display(Name = "Image")]
        public int imageID { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string image { get; set; }

        [Required]
        [Display(Name = "Published To Facebook?")]
        public bool publishedToFacebook { get; set; }
    }
}
