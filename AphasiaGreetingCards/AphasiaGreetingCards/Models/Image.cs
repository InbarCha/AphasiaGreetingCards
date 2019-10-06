using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AphasiaGreetingCards.Models
{
    public class Image
    {
        public int ID { get; set; }
        public string imagePath { get; set; }
        public string theme { get; set; }
        public string resolution { get; set; } //high or low
        public int digitalSize { get; set; }

    }
}
