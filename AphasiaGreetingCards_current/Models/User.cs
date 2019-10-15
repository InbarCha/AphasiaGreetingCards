using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AphasiaGreetingCards.Models
{
    [Table("AspNetUsers")]
    public class User : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        [Column("FirstName")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [Column("LastName")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Age")]
        [Column("Age")]
        public int Age { get; set; }

        [Required]
        [Column("Birthday")]
        public string Birthday { get; set; }

        [Required]
        [Column("City")]
        public string City { get; set; }

        [Column("isAdmin")]
        public bool isAdmin { get; set; }

        [Column("isFacebook")]
        public bool isFacebook { get; set; }

        //for K-Means:
        //{0} - Birthday, 
        //{1} - Bar Mitzva
        //{2} - It's a boy!
        //{3} - Daily
        //{4} - It's a girl!
        //{5} - Holiday
        //{6} - Love
        //{7} - Valentine
        //{8} - Wedding

        public IEnumerable<User> Friends { get; set; }
        
        public User(string FirstName, string LastName, string Email, string UserName, int Age, string Birthday, string City) 
        {
            this.UserName = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Birthday = Birthday;
            this.City = City;
            this.Email = Email;
        }

        public User ()
        {
        }
    }
}
