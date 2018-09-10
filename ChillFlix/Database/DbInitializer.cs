using ChillFlix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChillFlix.Database
{
    public static class DbInitializer
    {
        public static void Initialize(ChillflixDbContext context)
        {
            context.Database.EnsureCreated();
            List<Movie> movies = new List<Movie>
            {
                new Movie("hi!", "https://www.youtube.com/watch?v=dQw4w9WgXcQ", 212, "Music Videos")
            };

            Category[] categories = new Category[]
            {
                new Category("Music Videos", movies)
            };


            if (!context.Movies.Any())
            {
                foreach (Movie m in movies)
                {
                    context.Movies.Add(m);
                }

                context.SaveChanges();
            }

            if (!context.Categories.Any())
            {
                foreach (Category c in categories)
                {
                    context.Categories.Add(c);
                }

                context.SaveChanges();
            }
            
        }
    }
}
