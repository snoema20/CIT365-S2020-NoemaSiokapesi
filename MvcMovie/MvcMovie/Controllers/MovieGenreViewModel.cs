using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace MvcMovie.Controllers
{
    internal class MovieGenreViewModel
    {
        public SelectList Genres { get; set; }
        public System.Collections.Generic.List<Models.Movie> Movies { get; set; }
        public string SearchString { get; internal set; }
    }
}

namespace MvcMovie.Models
{
    internal class Movie
    {
        public Movie()
        {
        }

        public string Title { get; internal set; }
        public DateTime ReleaseDate { get; internal set; }
        public string Genre { get; internal set; }
        public string Rating { get; internal set; }
        public decimal Price { get; internal set; }
        public int? Id { get; internal set; }
    }
}