using System;

namespace MyScriptureJournal.Models
{
    internal class Scripture
    {
        public string NoteTitle { get; set; }
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string Note { get; set; }
        public string Passage { get; set; }
        public DateTime DateAdded { get; set; }
    }
}