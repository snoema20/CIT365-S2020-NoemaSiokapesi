using System;
using System.Threading.Tasks;

namespace My_Scripture_Journal
{
    public class Models
    {
        public class My_Scripture_JournalContext
        {
            public object Entry { get; internal set; }

            internal Task SaveChangesAsync()
            {
                throw new NotImplementedException();
            }
        }

        internal class My_ScriptureJournalContext
        {
        }

        internal class MyScriptureJournalContext
        {
            public object Entry { get; internal set; }

            public static implicit operator MyScriptureJournalContext(My_Scripture_JournalContext v)
            {
                throw new NotImplementedException();
            }
        }
    }
}