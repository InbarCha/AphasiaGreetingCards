using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AphasiaGreetingCards.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AphasiaGreetingCards.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AphasiaGreetingCards.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Users
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var users = _context.Users.ToListAsync();
            return View(await users);
        }

        // GET: Users/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Search(string firstName, string lastName, string city)
        {
            var selectedUsers = from u in _context.Users
                                             select u;

            //if all search parameters were given
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(city))
            {
                selectedUsers = selectedUsers.Where(g => g.FirstName == firstName && g.LastName == lastName 
                                                                      && g.City == city);
            }

            //only "firstName" and "lastName" were given
            else if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && string.IsNullOrEmpty(city))
            {
                selectedUsers = selectedUsers.Where(g => g.FirstName == firstName && g.LastName == lastName);
            }

            //only "firstName" and "city" were given
            else if (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(city))
            {
                selectedUsers = selectedUsers.Where(g => g.FirstName == firstName && g.City == city);
            }

            //only "lastName" and "city" were given
            else if (string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(city))
            {
                selectedUsers = selectedUsers.Where(g => g.LastName == lastName && g.City == city);
            }

            //only "lastName" was given
            else if (string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && string.IsNullOrEmpty(city))
            {
                selectedUsers = selectedUsers.Where(g => g.LastName == lastName);
            }

            //only "firstName" was given
            else if (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName) && string.IsNullOrEmpty(city))
            {
                selectedUsers = selectedUsers.Where(g => g.FirstName == firstName);
            }

            //only "city" was given
            else if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(city))
            {
                selectedUsers = selectedUsers.Where(g => g.City == city);
            }

            return View("Index", await selectedUsers.ToListAsync());
        }
    }
}
