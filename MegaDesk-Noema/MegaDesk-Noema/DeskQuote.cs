using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Noema
{
    class DeskQuote
    {
        public object CustomerName { get; internal set; }
        public object QuotePrice { get; internal set; }
        public ProductionType ProductionType { get; internal set; }
        public DateTime Date { get; internal set; }
        public Desk Desk { get; internal set; }

        internal object GetQuote()
        {
            throw new NotImplementedException();
        }
    }
}
