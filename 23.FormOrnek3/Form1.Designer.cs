
namespace _23.FormOrnek3
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
            this.txtbxSayi1 = new System.Windows.Forms.TextBox();
            this.txtbxSayi2 = new System.Windows.Forms.TextBox();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.lblSonuc2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxSayi1
            // 
            this.txtbxSayi1.Location = new System.Drawing.Point(92, 112);
            this.txtbxSayi1.Name = "txtbxSayi1";
            this.txtbxSayi1.Size = new System.Drawing.Size(100, 22);
            this.txtbxSayi1.TabIndex = 0;
            this.txtbxSayi1.TextChanged += new System.EventHandler(this.txtbxSayi1_TextChanged);
            // 
            // txtbxSayi2
            // 
            this.txtbxSayi2.Location = new System.Drawing.Point(92, 63);
            this.txtbxSayi2.Name = "txtbxSayi2";
            this.txtbxSayi2.Size = new System.Drawing.Size(100, 22);
            this.txtbxSayi2.TabIndex = 0;
            this.txtbxSayi2.TextChanged += new System.EventHandler(this.txtbxSayi2_TextChanged);
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(104, 214);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(75, 23);
            this.btnSonuc.TabIndex = 1;
            this.btnSonuc.Text = "Sonuc";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // lblSonuc2
            // 
            this.lblSonuc2.AutoSize = true;
            this.lblSonuc2.BackColor = System.Drawing.SystemColors.Window;
            this.lblSonuc2.Location = new System.Drawing.Point(304, 68);
            this.lblSonuc2.Name = "lblSonuc2";
            this.lblSonuc2.Size = new System.Drawing.Size(56, 17);
            this.lblSonuc2.TabIndex = 2;
            this.lblSonuc2.Text = "Sonuc2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSonuc2);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.txtbxSayi2);
            this.Controls.Add(this.txtbxSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxSayi1;
        private System.Windows.Forms.TextBox txtbxSayi2;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.Label lblSonuc2;
    }
}

