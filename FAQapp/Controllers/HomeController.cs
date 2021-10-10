using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using FAQapp.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace FAQapp.Controllers
{
    public class HomeController : Controller
    {
        private FAQContext context { get; set; }

        public HomeController(FAQContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index(string genreId = null, string catId = null)
        {
            if ((genreId != null) && (catId != null))
            {
                var faqs = context.FAQs
                    .Include(c => c.Category)
                    .Include(c => c.Genre)
                    .Where(c => c.GenreId == genreId)
                    .Where(c => c.CategoryId == catId)
                    .OrderBy(c => c.Name)
                    .ToList();
                return View(faqs);
            }
            if ((genreId == null) && (catId != null))
            {
                var faqs = context.FAQs
                    .Include(c => c.Category)
                    .Include(c => c.Genre)
                    .Where(c => c.CategoryId == catId)
                    .OrderBy(c => c.Name)
                    .ToList();
                return View(faqs);
            }
            else if ((genreId != null) && (catId == null))
            {
                var faqs = context.FAQs
                    .Include(c => c.Category)
                    .Include(c => c.Genre)
                    .Where(c => c.GenreId == genreId)
                    .OrderBy(c => c.Name)
                    .ToList();
                return View(faqs);
            }
            else
            {
                var faqs = context.FAQs
                    .Include(c => c.Category)
                    .Include(c => c.Genre)
                    .OrderBy(c => c.Name)
                    .ToList();
                return View(faqs);
            }
        }
    }
}
