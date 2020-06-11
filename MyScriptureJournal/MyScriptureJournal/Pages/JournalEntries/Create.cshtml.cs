using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Journal
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
            return Pages();
        }

        private IActionResult Pages()
        {
            throw new NotImplementedException();
        }

        private Models.JournalEntries journalEntry;

        public JournalEntry GetJournalEntry()
        {
            return journalEntry;
        }

        public void SetJournalEntry(JournalEntry value)
        {
            journalEntry = value;
        }

        public Models.JournalEntries JournalEntry { get; private set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
        {
            object ModelState = null;
            if (ModelState.Is.Valid)
            {


                return RedirectToPage("./Index");
            }
            return Pages();
        }

        private IActionResult RedirectToPage(string v)
        {
            throw new NotImplementedException();
        }
    }
}