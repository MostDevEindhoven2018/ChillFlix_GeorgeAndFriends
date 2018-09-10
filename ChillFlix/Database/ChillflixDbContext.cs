using ChillFlix.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChillFlix.Database
{
    public class ChillflixDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Creating the constructor for the class MyDBContext
        /// </summary>
        public ChillflixDbContext(DbContextOptions<ChillflixDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movies");
        }
    }
}
