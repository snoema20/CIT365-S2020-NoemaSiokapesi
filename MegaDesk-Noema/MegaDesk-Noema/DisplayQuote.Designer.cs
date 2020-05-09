using System.Windows.Forms;
using System.ComponentModel;
using System;

namespace MegaDesk_Noema
{
	public partial class DisplayQuote : Form
	{
		private object CustomerName;
		private object quote;
		private object depth;
		private object Drawers;
		private object NumberOfDrawers;
		private object surfaceMaterialOutput;
		private object SurfaceMaterial;
		private object rushOrder;
		private object dateOutput;
		private object Price;
		private object QuotePrice;

		//public DeskQuote Quote { get; }

		public DisplayQuote()
		{
			InitializeComponent();
			//Quote = quote;
			SetfullNameOutput(CustomerName);
			SetwidthOutput($"{quote}in");
			depthOutput = $"{quote}in";
			numberOfDrawersOutput = NumberOfDrawers.ToString();
			surfaceMaterialOutput = SurfaceMaterial.ToString();
			rushOrderOutput = (Attribute.GetCustomAttribute(quote.GetType().GetField(quote.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description
								   ?? quote.ToString();
			dateOutput = ToShortDateString();
			quotePriceOutput = $"${QuotePrice}";
		}

		private object ToShortDateString()
		{
			throw new NotImplementedException();
		}

		private object fullNameOutput1;

		public object GetfullNameOutput()
		{
			return fullNameOutput1;
		}

		private void SetfullNameOutput(object value)
		{
			fullNameOutput1 = value;
		}

		private object widthOutput1;

		public object NumberOfDrawers1
		{
			get => this.numberOfDrawers; (values)
			
		}

		public object GetwidthOutput()
		{
			return widthOutput1;
		}

		private void SetwidthOutput(object value)
		{
			widthOutput1 = value;
		}

		private void InitializeComponent()
		{
			throw new NotImplementedException();
		}
	}
}