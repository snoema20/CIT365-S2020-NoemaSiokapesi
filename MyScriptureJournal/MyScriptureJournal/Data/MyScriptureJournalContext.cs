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

        public object JournalEntry { get; internal set; }
        public object MyScriptureJournal { get; internal set; }
        public object Scripture { get; internal set; }
    }
}