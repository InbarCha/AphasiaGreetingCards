using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AphasiaGreetingCards.Models
{
    public class Image
    {
        public int ID { get; set; }

        [Display(Name = "Image")]
        public string imagePath { get; set; }

        [Display(Name = "Theme")]
        public string theme { get; set; }

        [Display(Name = "Resolution")]
        public string resolution { get; set; } //high or low

        [Display(Name = "Digital Size")]
        public int digitalSize { get; set; }

    }
}
