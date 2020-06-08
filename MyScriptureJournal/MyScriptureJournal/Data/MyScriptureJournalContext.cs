using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyScriptureJournal.Models
{
    public class My_Scripture_JournalContext : DbContext
    {
        public My_Scripture_JournalContext(DbContextOptions<My_Scripture_JournalContext> options)
            : base(options)
        {
        }

        public DbSet<My_Scripture_Journal.Models.Scripture> Scripture { get; set; }
    }
}