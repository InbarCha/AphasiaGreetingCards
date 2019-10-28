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

        [AllowAnonymous]
        public async Task<IActionResult> Search(string imageName, string resolution, string theme)
        {
            var selectedImages = from im in _context.Images
                                             select im;

            //if all search parameters were given
            if (!string.IsNullOrEmpty(theme) && !string.IsNullOrEmpty(resolution) && !string.IsNullOrEmpty(imageName))
            {
                selectedImages = selectedImages.Where(g => g.theme == theme && g.resolution == resolution
                                                                      && g.imageName == imageName);
            }

            //only "theme" and "resolution" were given
            else if (!string.IsNullOrEmpty(theme) && !string.IsNullOrEmpty(resolution) && string.IsNullOrEmpty(imageName))
            {
                selectedImages = selectedImages.Where(g => g.theme == theme && g.resolution == resolution);
            }

            //only "theme" and "imageName" were given
            else if (!string.IsNullOrEmpty(theme) && string.IsNullOrEmpty(resolution) && !string.IsNullOrEmpty(imageName))
            {
                selectedImages = selectedImages.Where(g => g.theme == theme && g.imageName == imageName);
            }

            //only "imageName" and "resolution" were given
            else if (string.IsNullOrEmpty(theme) && !string.IsNullOrEmpty(imageName) && !string.IsNullOrEmpty(resolution))
            {
                selectedImages = selectedImages.Where(g => g.imageName == imageName && g.resolution == resolution);
            }

            //only "imageName" was given
            else if (string.IsNullOrEmpty(theme) && !string.IsNullOrEmpty(imageName) && string.IsNullOrEmpty(resolution))
            {
                selectedImages = selectedImages.Where(g => g.imageName == imageName);
            }

            //only "resolution" was given
            else if (!string.IsNullOrEmpty(resolution) && string.IsNullOrEmpty(theme) && string.IsNullOrEmpty(imageName))
            {
                selectedImages = selectedImages.Where(g => g.resolution == resolution);
            }

            //only "theme" was given
            else if (string.IsNullOrEmpty(resolution) && string.IsNullOrEmpty(imageName) && !string.IsNullOrEmpty(theme))
            {
                selectedImages = selectedImages.Where(g => g.theme == theme);
            }

            return View("Index", await selectedImages.ToListAsync());
        }
    }
}
