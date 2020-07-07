using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoUniversity.Pages
{

public class IndexModel : PageModel
    {
        private readonly SchoolContext _context;
        private SchoolContext context;

        public IndexModel()
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        internal SchoolContext Context { get => context; set => context = value; }
        internal SchoolContext Context1 { get => context; set => context = value; }

        public void OnGet()
        {

        }
    }
}
