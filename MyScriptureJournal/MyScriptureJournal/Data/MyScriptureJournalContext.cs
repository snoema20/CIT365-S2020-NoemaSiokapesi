
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Pages.Journal;

namespace MyScriptureJournal.Models
{
    public class MyScriptureJournalContext : DbContext
    {
        public MyScriptureJournalContext(DbContextOptions<MyScriptureJournalContext> options)
            : base(options)
        {
        }

        public DbSet<MyScriptureJournal.Models.JournalEntry> JournalEntry { get; set; }
        public object Scripture { get; internal set; }
    }

    public class JournalEntry
    {
        public JournalEntry()
        {
        }

        public string Book { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public string Note { get; internal set; }
        public int? ID { get; internal set; }

        public static implicit operator JournalEntry(MyScriptureJournal.Pages.Journal.JournalEntry v)
        {
            throw new NotImplementedException();
        }
    }
}