using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ChillFlix.Database;
using Microsoft.AspNetCore.Mvc;

namespace ChillFlix.Controllers
{

   
    public class HomeController : Controller
    {
        ChillflixDbContext _context;

        public HomeController(ChillflixDbContext context)
        {
            //_AvailabilityCheck = new CheckTableAvailability(context);
            _context = context;
        }

        public IActionResult Index()
        {
            _context.Database.EnsureCreated();
            DbInitializer.Initialize(_context);
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
