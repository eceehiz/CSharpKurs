
namespace _30.ConnectedMimari_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.lstKategoriler = new System.Windows.Forms.ListBox();
            this.lstTedarikciler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 16;
            this.lstUrunler.Location = new System.Drawing.Point(21, 23);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(391, 260);
            this.lstUrunler.TabIndex = 0;
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.FormattingEnabled = true;
            this.lstKategoriler.ItemHeight = 16;
            this.lstKategoriler.Location = new System.Drawing.Point(439, 23);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(169, 260);
            this.lstKategoriler.TabIndex = 1;
            // 
            // lstTedarikciler
            // 
            this.lstTedarikciler.FormattingEnabled = true;
            this.lstTedarikciler.ItemHeight = 16;
            this.lstTedarikciler.Location = new System.Drawing.Point(665, 23);
            this.lstTedarikciler.Name = "lstTedarikciler";
            this.lstTedarikciler.Size = new System.Drawing.Size(325, 260);
            this.lstTedarikciler.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 560);
            this.Controls.Add(this.lstTedarikciler);
            this.Controls.Add(this.lstKategoriler);
            this.Controls.Add(this.lstUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.ListBox lstKategoriler;
        private System.Windows.Forms.ListBox lstTedarikciler;
    }
}

