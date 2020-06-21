using System;

namespace MvcMovie.Models
{
    public class Movie
    {
        internal object Title;

        public DateTime ReleaseDate { get; internal set; }
        public string Genre { get; internal set; }
        public decimal Price { get; internal set; }
        public int? ID { get; internal set; }
        public int? Id { get; internal set; }
    }
}