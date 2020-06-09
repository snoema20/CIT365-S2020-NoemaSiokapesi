using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.JournalEntries
{
    public class DeleteModel : PageModel
    {
        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public DeleteModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.JournalEntries JournalEntry { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JournalEntry = await _context.JournalEntry.FirstOrDefaultAsync(m => m.ID == id);

            if (JournalEntry == null)
            {
                return NotFound();
            }
            return Page();
        }

        private IActionResult Page()
        {
            throw new NotImplementedException();
        }

        private IActionResult NotFound()
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JournalEntry = await _context.JournalEntry.FindAsync(id);

            if (JournalEntry != null)
            {
                _context.JournalEntry.Remove(JournalEntry);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }

        private IActionResult RedirectToPage(string v)
        {
            throw new NotImplementedException();
        }
    }
}
