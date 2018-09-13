using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChillFlix.Database;
using ChillFlix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChillFlix.Controllers
{
    [Route("api/[controller]")]
    public class AngularMovieController : Controller
    {
        private readonly ChillflixDbContext _context;

        public AngularMovieController(ChillflixDbContext context)
        {
            _context = context;
        }
        
        [HttpGet("[action]")]
        public  IEnumerable<Movie> Movies()
        {
            return   _context.Movies.ToList();
        }
    }
}