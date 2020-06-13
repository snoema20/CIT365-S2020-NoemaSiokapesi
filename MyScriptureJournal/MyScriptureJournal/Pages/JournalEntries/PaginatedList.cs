using MyScriptureJournal.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Pages.JournalEntries
{
    internal class PaginatedList<T>
    {
        internal static Task<PaginatedList<Models.JournalEntry>> CreateAsync(IQueryable<Models.JournalEntry> queryable, int v, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}