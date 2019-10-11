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

namespace AphasiaGreetingCards.Controllers
{
    [Authorize]
    public class ImagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ImagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Images
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Images.ToListAsync());
        }

        private bool ImageExists(int id)
        {
            return _context.Images.Any(e => e.ID == id);
        }
    }
}
