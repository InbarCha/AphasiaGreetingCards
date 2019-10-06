using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AphasiaGreetingCards.Models
{
    public class SentimentSentence
    {
        public int ID { get; set; }
        public string theme { get; set; }
        public string prefix { get; set; }
        public int recipientUserID { get; set; }
        public string suffix { get; set; }
        public string complexity { get; set; } //high or low
    }
}
