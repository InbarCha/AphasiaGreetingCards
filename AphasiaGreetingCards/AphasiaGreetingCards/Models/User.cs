using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AphasiaGreetingCards.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "User Name")]
        public string username { get; set; }

        public string password { get; set; }

        [Display(Name = "Age")]
        public int age { get; set; }

        [Display(Name = "Birthday Date")]
        public DateTime birthdayDate { get; set; }

        [Display(Name = "City")]
        public string city { get; set; }

        [Display(Name = "Manager/Not Manager")]
        public bool isManager { get; set; }

        public ICollection<User> Friends { get; set; }

    }
}
