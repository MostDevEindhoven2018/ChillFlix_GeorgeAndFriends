using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChillFlix.Models
{
    public class Movie
    {
        public int MovieID { get; set; }


        public string Title { get; set; }
        public string Link { get; set; }
        public int Length { get; set; }

        // Do we want to double couple this or just let the category be a list of movies?
        public Category Category { get; set; }

        public Movie() { }

        public Movie( string title, string link, int length, Category category)
        {
            Title = title;
            Link = link;
            Length = length;
            Category = category;
        }
    }
}
