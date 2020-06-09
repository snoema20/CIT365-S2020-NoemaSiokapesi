using MyScriptureJournal.Models;
using System;

namespace MyScriptureJournal.Pages.Journal
{
    public class JournalEntry
    {
        public static implicit operator JournalEntry(JournalEntries v)
        {
            throw new NotImplementedException();
        }
    }
}