
using System.Windows.Forms;

namespace MegaDesk_Noema
{
	public partial class ViewAllQuotes : Form
	{
		public ViewAllQuotes()
		{
			InitializeComponent();
		}

		private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
		}
	}
}