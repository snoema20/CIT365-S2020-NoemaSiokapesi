﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace My_Scripture_Journal.Pages.Entries
{
    public class CreateModel : PageModel
    {
        private readonly My_Scripture_Journal.Models.My_Scripture_JournalContext _context;

        public CreateModel(My_Scripture_Journal.Models.My_Scripture_JournalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Entry Entry { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Entry.Add(Entry);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Details");
        }
    }

    public class Entry
    {
        public object ID { get; internal set; }
        public object Book { get; internal set; }
        public bool DatePosted { get; internal set; }
    }
}
