using System;

namespace MvcMovie.Models
{
    public class Movie
    {
        public string Title { get; internal set; }
        public DateTime ReleaseDate { get; internal set; }
        public string Genre { get; internal set; }
        public string Rating { get; internal set; }
        public decimal Price { get; internal set; }
        public int? Id { get; internal set; }
    }
}