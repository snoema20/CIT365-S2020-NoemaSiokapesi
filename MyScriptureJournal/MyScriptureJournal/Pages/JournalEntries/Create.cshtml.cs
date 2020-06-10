using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyScriptureJournal.Models;
using MyScriptureJournal.Pages.Journal;

namespace MyScriptureJournal.Pages.JournalEntries
{
    public class CreateModel : PageModel
    {
        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public CreateModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        private IActionResult Page()
        {
            throw new NotImplementedException();
        }

        [BindProperty]
        public JournalEntry JournalEntries { get; set; }
        public object ModelState { get; private set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                ;
            }

            {
                return Page();
            }
        }

        private IActionResult RedirectToPage(string v)
        {
            throw new NotImplementedException();
        }
    }
}