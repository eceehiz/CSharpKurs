
namespace _34.Procedure_Form
{
    partial class Tedarikciler
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
            this.lblSirket = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.txtSirket = new System.Windows.Forms.TextBox();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSirket
            // 
            this.lblSirket.AutoSize = true;
            this.lblSirket.Location = new System.Drawing.Point(131, 80);
            this.lblSirket.Name = "lblSirket";
            this.lblSirket.Size = new System.Drawing.Size(68, 17);
            this.lblSirket.TabIndex = 0;
            this.lblSirket.Text = "Sirket Adi";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(300, 80);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(78, 17);
            this.lblMusteri.TabIndex = 1;
            this.lblMusteri.Text = "Musteri Adi";
            // 
            // txtSirket
            // 
            this.txtSirket.Location = new System.Drawing.Point(124, 122);
            this.txtSirket.Name = "txtSirket";
            this.txtSirket.Size = new System.Drawing.Size(100, 22);
            this.txtSirket.TabIndex = 2;
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(303, 122);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(100, 22);
            this.txtMusteri.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(469, 121);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvListe
            // 
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(88, 220);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.RowHeadersWidth = 51;
            this.dgvListe.RowTemplate.Height = 24;
            this.dgvListe.Size = new System.Drawing.Size(592, 150);
            this.dgvListe.TabIndex = 5;
            // 
            // Tedarikciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.txtSirket);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.lblSirket);
            this.Name = "Tedarikciler";
            this.Text = "Tedarikciler";
            this.Load += new System.EventHandler(this.Tedarikciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSirket;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.TextBox txtSirket;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvListe;
    }
}