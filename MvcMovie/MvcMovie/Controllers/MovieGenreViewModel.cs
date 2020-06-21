using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Controllers
{
    internal class MovieGenreViewModel
    {
        public SelectList Genres { get; set; }
        public System.Collections.Generic.List<Models.Movie> Movies { get; set; }
        public string SearchString { get; internal set; }
    }
}