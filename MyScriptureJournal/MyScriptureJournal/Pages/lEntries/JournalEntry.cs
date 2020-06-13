using MyScriptureJournal.Models;
using System;

namespace MyScriptureJournal.Pages.Journal
{
    public class JournalEntry
    {
        public object ID { get; internal set; }

        public static implicit operator JournalEntry(JournalEntry v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator JournalEntry(Models.JournalEntry v)
        {
            throw new NotImplementedException();
        }
    }
}