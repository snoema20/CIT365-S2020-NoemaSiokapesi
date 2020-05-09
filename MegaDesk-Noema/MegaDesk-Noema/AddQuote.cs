using MegaDesk_Noema.Properties;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk_Noema
{
	public partial class AddNewQuote : Form
	{
		private object nameRequiredErrorMessage;
		private object materialSelect;
		private object rushOrderSelect;
		private object fullNameInput;
		private object numberOfDrawers;
		private object widthUpDown;
		private object dateLabel;
		private int value;
		private DesktopMaterial selectedItem;

		public AddNewQuote()
		{
			InitializeComponent();
			nameRequiredErrorMessage = string.Empty;
			materialSelect = Enum.GetValues(typeof(DesktopMaterial));
			rushOrderSelect = Enum.GetValues(typeof(ProductionType)).Cast<Enum>()
				.Select(p => new
				{
					Description = (Attribute.GetCustomAttribute(p.GetType().GetField(p.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description
								 ?? p.ToString(),
					Value = p
				}).ToList();
			rushOrderSelect = "Description";
			rushOrderSelect = "Value";
			dateLabel = DateTime.Today.ToShortDateString();
		}
		private void InitializeComponent()
		{
			throw new NotImplementedException();
		}

		private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
		}

		private void GetQuoteButton_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(fullNameInput,))
			{
				Desk desk = new Desk()
				{
					Depth = (int)value,
					Width = (int)value,
					NumberOfDrawers = (int)value,
					SurfaceMaterial = selectedItem
				};

				DeskQuote quote = new DeskQuote()
				{
					CustomerName = fullNameInput,
					Desk = desk,
					ProductionType = (ProductionType)rushOrderSelect,
					Date = DateTime.Now
				};

				quote.QuotePrice = quote.GetQuote();

				DisplayQuote displayQuote = new DisplayQuote(quote);
				displayQuote.ShowDialog();
			}
			else
			{
				nameRequiredErrorMessage = Resources.Required;
				return;
			}
		}
	}
}