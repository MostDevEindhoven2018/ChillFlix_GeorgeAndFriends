using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChillFlix.Models
{
    public class Category
    {
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }
        public int Length
        {
            get { return Movies.Count; }
        }
    }
}
