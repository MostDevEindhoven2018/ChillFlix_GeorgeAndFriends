using ChillFlix.Database;
using ChillFlix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_MVC_MolvenoReservationApplication.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ChillflixDbContext context)
        {
            context.Database.EnsureCreated();
            Movie[] movies = new Movie[]
            {
                new Movie
            };

            if (!context.Movies.Any())
            {
                foreach (Table t in Tables)
                {
                    context.Tables.Add(t);
                }

                context.SaveChanges();
            }

            if (!context.Categories.Any())
            {
                foreach (Guest g in Guests)
                {
                    context.Guests.Add(g);
                }

                context.SaveChanges();
            }
            
        }
    }
}
