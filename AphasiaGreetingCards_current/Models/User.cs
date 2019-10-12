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
