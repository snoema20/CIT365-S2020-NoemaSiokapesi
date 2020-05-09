using System.ComponentModel;
using System.Windows.Forms;

namespace MegaDesk_Noema
{
	partial class AddNewQuote
	{
		private const string V = "fullNameInput";

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		new

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// 
		void Dispose()
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			object p = base.Disposing;
		}

		#region Windows Form Designer generated code

		#endregion

		private System.Windows.Forms.NumericUpDown WidthUpDown;
		private NumericUpDown numericUpDown;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;

		public NumericUpDown NumericUpDown { get; private set; }

		private System.Windows.Forms.NumericUpDown DepthUpDown;
		private System.Windows.Forms.Label label3;

		public TextBox FullNameInput { get; private set; }
		public NumericUpDown NumberOfDrawersUpDown { get; private set; }

		private System.Windows.Forms.TextBox FullName;
		private System.Windows.Forms.NumericUpDown NumberOfDrawers;
		private System.Windows.Forms.Label label4;

		public ComboBox MaterialSelect { get; private set; }

		private System.Windows.Forms.ComboBox Material;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;

		public ComboBox RushOrderSelect { get; private set; }
		public Label DateLabel { get; private set; }

		private System.Windows.Forms.ComboBox OrderSelect;
		private System.Windows.Forms.Label date;
		private System.Windows.Forms.Button getQuoteButton;

		public Label NameRequiredErrorMessage { get; private set; }
		public TextBox FullNameInput1 { get => this.FullNameInput; set => this.FullNameInput = value; }
		public ComboBox MaterialSelect1 { get => this.MaterialSelect; set => this.MaterialSelect = value; }

		private ISupportInitialize widthUpDown1;

		public ISupportInitialize GetWidthUpDown()
		{
			return widthUpDown1;
		}

		private void SetWidthUpDown(ISupportInitialize value)
		{
			widthUpDown1 = value;
		}

		private ISupportInitialize depthUpDown1;

		public ISupportInitialize GetDepthUpDown()
		{
			return depthUpDown1;
		}

		private void SetDepthUpDown(ISupportInitialize value)
		{
			depthUpDown1 = value;
		}

		private System.Windows.Forms.Label ErrorMessage;
		private bool disposing;
	}
}