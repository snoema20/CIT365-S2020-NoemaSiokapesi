using System;
using System.Windows.Forms;

namespace MegaDesk_Noema
{
    public partial class ViewQuotes : Form
    {
        public ViewQuotes()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeForm homeForm = (HomeForm)Tag;
            homeForm.Show();
        }
    }
}