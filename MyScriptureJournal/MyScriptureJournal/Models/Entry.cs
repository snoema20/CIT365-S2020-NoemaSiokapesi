using System;
using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class JournalsEntry
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
        public string Book { get; set; }
        public string Reference { get; set; }
        public string Notes { get; set; }
    }
}