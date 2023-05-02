
namespace _34.Procedure_Form
{
    partial class Kategoriler
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
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.txtTanimi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.lblKategoriAd = new System.Windows.Forms.Label();
            this.lblTanim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(195, 139);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(100, 22);
            this.txtKategoriAd.TabIndex = 0;
            // 
            // txtTanimi
            // 
            this.txtTanimi.Location = new System.Drawing.Point(329, 139);
            this.txtTanimi.Name = "txtTanimi";
            this.txtTanimi.Size = new System.Drawing.Size(100, 22);
            this.txtTanimi.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(469, 137);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvListe
            // 
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(54, 281);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.RowHeadersWidth = 51;
            this.dgvListe.RowTemplate.Height = 24;
            this.dgvListe.Size = new System.Drawing.Size(660, 150);
            this.dgvListe.TabIndex = 3;
            // 
            // lblKategoriAd
            // 
            this.lblKategoriAd.AutoSize = true;
            this.lblKategoriAd.Location = new System.Drawing.Point(210, 95);
            this.lblKategoriAd.Name = "lblKategoriAd";
            this.lblKategoriAd.Size = new System.Drawing.Size(85, 17);
            this.lblKategoriAd.TabIndex = 4;
            this.lblKategoriAd.Text = "Kategori Adı";
            // 
            // lblTanim
            // 
            this.lblTanim.AutoSize = true;
            this.lblTanim.Location = new System.Drawing.Point(348, 95);
            this.lblTanim.Name = "lblTanim";
            this.lblTanim.Size = new System.Drawing.Size(50, 17);
            this.lblTanim.TabIndex = 5;
            this.lblTanim.Text = "Tanımı";
            // 
            // Kategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.lblTanim);
            this.Controls.Add(this.lblKategoriAd);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTanimi);
            this.Controls.Add(this.txtKategoriAd);
            this.Name = "Kategoriler";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Kategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.TextBox txtTanimi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Label lblKategoriAd;
        private System.Windows.Forms.Label lblTanim;
    }
}