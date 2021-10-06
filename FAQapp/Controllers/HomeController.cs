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

        public IActionResult Index()
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
