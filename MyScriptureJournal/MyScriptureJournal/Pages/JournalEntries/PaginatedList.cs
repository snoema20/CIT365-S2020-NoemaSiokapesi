using MyScriptureJournal.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Pages.Journal
{
    internal class PaginatedList<T>
    {
        internal static Task<PaginatedList<Models.JournalEntries>> CreateAsync(IQueryable<Models.JournalEntries> queryable, int v, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}