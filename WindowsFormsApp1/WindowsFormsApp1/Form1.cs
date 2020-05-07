using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Noema
{
    public partial class Form1 : Form
    {
        public object ViewSearchQuotes { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void NewQuote_Click(object sender, EventArgs e)
        {
            MakeQuote NewQuoteForm = new MakeQuote();
            NewQuoteForm.Tag = this;
            NewQuoteForm.Show();
            Hide();
        
    }
    private void ViewAll_Click(object sender, EventArgs e)
    {
        ViewQuotes ViewQuotesForm = new ViewQuotes();
        ViewQuotesForm.Tag = this;
        ViewQuotesForm.Show();
        Hide();
    }
    private void Search_Click(object sender, EventArgs e)
    {
            SearchQuotes searchQuotes = new SearchQuotes()
            {
                Tag = this,
            };
            SearchQuotes ViewSearchQuote = searchQuotes;
            _ = ViewSearchQuotes.Show();
            Hide();
    }
    private void Exit_Click(object sender, EventArgs e)
    {
        Close();
    }
}
}
    
