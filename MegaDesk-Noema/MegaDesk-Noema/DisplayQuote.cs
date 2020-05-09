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
    public partial class DisplayQuote : Form
    {
		private object fullNameOutput;
		private object widthOutput;
		private object depthOutput;

		public string numberOfDrawers { get; private set; }

		private object numberOfDrawersOutput;
		private object MaterialOutput;
		private string OrderOutput;
		private object Material;
		private object Order;
		private object rushOrderOutput;
		private object DateOutput;
		private string PriceOutput;
		private object quotePriceOutput;

		public DisplayQuote(object quote)
        {
            InitializeComponent();
			//Quote = quote;
			GetfullNameOutput().Text = quote.CustomerName;
			GetwidthOutput().Text = $"{quote.Desk.Width}in";
			depthOutput.Text = $"{quote.Desk.Depth}in";
			numberOfDrawersOutput.Text = quote.Desk.NumberOfDrawers.ToString();
			Material.Text = quote.Desk.SurfaceMaterial.ToString();
			rushOrderOutput.Text = (Attribute.GetCustomAttribute(quote.ProductionType.GetType()
																			.GetField(quote.ProductionType.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description
								   ?? quote.ProductionType.ToString();
			DateOutput.Text = quote.Date.ToShortDateString();
			quotePriceOutput.Text = $"${quote.QuotePrice}";
		}
    }
}
