using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<teacher> Teachers { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }

        public List<Movie> Movies { get; set; }
        public SelectList Genres1 { get; set; }
        public string MovieGenre1 { get; set; }
        public string SearchString1 { get; set; }

    }
}