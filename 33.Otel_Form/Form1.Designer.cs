
namespace _33.Otel_Form
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.gbxMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblUyruk = new System.Windows.Forms.Label();
            this.cbmUyruk = new System.Windows.Forms.ComboBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.mtxtTelNo = new System.Windows.Forms.MaskedTextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.gbxMusteriBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(58, 37);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 17);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(35, 73);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(48, 17);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(36, 140);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(47, 17);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "E-Mail";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(41, 178);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(42, 17);
            this.lblTc.TabIndex = 4;
            this.lblTc.Text = "TcNo";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(115, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 22);
            this.txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(115, 68);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(121, 22);
            this.txtSoyad.TabIndex = 6;
            // 
            // gbxMusteriBilgileri
            // 
            this.gbxMusteriBilgileri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbxMusteriBilgileri.Controls.Add(this.btnSil);
            this.gbxMusteriBilgileri.Controls.Add(this.btnGuncelle);
            this.gbxMusteriBilgileri.Controls.Add(this.btnEkle);
            this.gbxMusteriBilgileri.Controls.Add(this.lblUyruk);
            this.gbxMusteriBilgileri.Controls.Add(this.cbmUyruk);
            this.gbxMusteriBilgileri.Controls.Add(this.txtTcNo);
            this.gbxMusteriBilgileri.Controls.Add(this.txtMail);
            this.gbxMusteriBilgileri.Controls.Add(this.mtxtTelNo);
            this.gbxMusteriBilgileri.Controls.Add(this.lblAd);
            this.gbxMusteriBilgileri.Controls.Add(this.txtSoyad);
            this.gbxMusteriBilgileri.Controls.Add(this.lblSoyad);
            this.gbxMusteriBilgileri.Controls.Add(this.txtAd);
            this.gbxMusteriBilgileri.Controls.Add(this.lblTelNo);
            this.gbxMusteriBilgileri.Controls.Add(this.lblTc);
            this.gbxMusteriBilgileri.Controls.Add(this.lblMail);
            this.gbxMusteriBilgileri.Location = new System.Drawing.Point(27, 27);
            this.gbxMusteriBilgileri.Name = "gbxMusteriBilgileri";
            this.gbxMusteriBilgileri.Size = new System.Drawing.Size(318, 327);
            this.gbxMusteriBilgileri.TabIndex = 7;
            this.gbxMusteriBilgileri.TabStop = false;
            this.gbxMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(218, 273);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 23);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.btnGuncelle.Location = new System.Drawing.Point(115, 273);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(86, 23);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Lime;
            this.btnEkle.Location = new System.Drawing.Point(12, 273);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(86, 23);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblUyruk
            // 
            this.lblUyruk.AutoSize = true;
            this.lblUyruk.Location = new System.Drawing.Point(37, 221);
            this.lblUyruk.Name = "lblUyruk";
            this.lblUyruk.Size = new System.Drawing.Size(45, 17);
            this.lblUyruk.TabIndex = 11;
            this.lblUyruk.Text = "Uyruk";
            // 
            // cbmUyruk
            // 
            this.cbmUyruk.FormattingEnabled = true;
            this.cbmUyruk.Items.AddRange(new object[] {
            "Türkiye",
            "Almanya",
            "Arnavut",
            "Arabistan",
            "Çin",
            "Japonya",
            "Rusya",
            "Türkmenistan"});
            this.cbmUyruk.Location = new System.Drawing.Point(115, 214);
            this.cbmUyruk.Name = "cbmUyruk";
            this.cbmUyruk.Size = new System.Drawing.Size(121, 24);
            this.cbmUyruk.TabIndex = 10;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(115, 173);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(121, 22);
            this.txtTcNo.TabIndex = 9;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(115, 135);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(121, 22);
            this.txtMail.TabIndex = 8;
            // 
            // mtxtTelNo
            // 
            this.mtxtTelNo.Location = new System.Drawing.Point(115, 101);
            this.mtxtTelNo.Mask = "(999) 000-0000";
            this.mtxtTelNo.Name = "mtxtTelNo";
            this.mtxtTelNo.Size = new System.Drawing.Size(121, 22);
            this.mtxtTelNo.TabIndex = 7;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(5, 106);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(78, 17);
            this.lblTelNo.TabIndex = 2;
            this.lblTelNo.Text = "Telefon No";
            // 
            // dgvListe
            // 
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(377, 27);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.RowHeadersWidth = 51;
            this.dgvListe.RowTemplate.Height = 24;
            this.dgvListe.Size = new System.Drawing.Size(411, 411);
            this.dgvListe.TabIndex = 12;
            this.dgvListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxMusteriBilgileri);
            this.Controls.Add(this.dgvListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxMusteriBilgileri.ResumeLayout(false);
            this.gbxMusteriBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.GroupBox gbxMusteriBilgileri;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Label lblUyruk;
        private System.Windows.Forms.ComboBox cbmUyruk;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mtxtTelNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Button btnSil;
    }
}

