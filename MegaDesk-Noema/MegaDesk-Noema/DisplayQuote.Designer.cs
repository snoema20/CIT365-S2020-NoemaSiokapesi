using System;
using System.Drawing;
using System.Windows.Forms;

namespace MegaDesk
{
    partial class DisplayQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public new SizeF AutoScaleDimensions { get; private set; }
        public new AutoScaleMode AutoScaleMode { get; private set; }
        public new Size ClientSize { get; private set; }
        public new string Name { get; private set; }
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        public string Text { get; private set; }
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
        void Dispose(bool disposing)
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 413);
            this.Name = "DisplayQuote";
            this.Text = "Display Quote";
            this.ResumeLayout(false);

        }

        private new void SuspendLayout()
        {
            throw new NotImplementedException();
        }

        private new void ResumeLayout(bool v)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}