﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChillFlix.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public int Length { get; set; }

        // Do we want to double couple this or just let the category be a list of movies?
        public string Category { get; set; }


        public Movie( string title, string link, int length, string category)
        {
            Title = title;
            Link = link;
            Length = length;
            Category = category;
        }
    }
}
