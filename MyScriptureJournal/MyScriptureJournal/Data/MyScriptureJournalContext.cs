using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using My_Scripture_Journal.Models;

namespace MyScriptureJournal.Models
{
    public class MyScriptureJournalContext : DbContext
    {
        public MyScriptureJournalContext (DbContextOptions<MyScriptureJournalContext> options)
            : base(options)
        {
        }

        public DbSet<My_Scripture_Journal.Models.Scripture> Scripture { get; set; }
    }
}
