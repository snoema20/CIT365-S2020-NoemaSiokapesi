
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyScriptureJournal.Models
{
    public class MyScriptureJournalContext : DbContext
    {
        public MyScriptureJournalContext(DbContextOptions<MyScriptureJournalContext> options)
            : base(options)
        {
        }

        public DbSet<MyScriptureJournal.Models.JournalEntries> JournalEntry { get; set; }
    }

    public class JournalEntries
    {
        public JournalEntries()
        {
        }

        public string Book { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public string Note { get; internal set; }
        public int? ID { get; internal set; }
    }
}