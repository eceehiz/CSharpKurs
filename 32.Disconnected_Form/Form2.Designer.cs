
namespace _32.Disconnected_Form
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satislarSorgusuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRaporListesi = new System.Windows.Forms.DataGridView();
            this.lblRaporBaslik = new System.Windows.Forms.Label();
            this.yıllıkSatışlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satislarSorgusuToolStripMenuItem,
            this.yıllıkSatışlarToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // satislarSorgusuToolStripMenuItem
            // 
            this.satislarSorgusuToolStripMenuItem.Name = "satislarSorgusuToolStripMenuItem";
            this.satislarSorgusuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.satislarSorgusuToolStripMenuItem.Text = "Satışlar Sorgusu";
            this.satislarSorgusuToolStripMenuItem.Click += new System.EventHandler(this.satislarSorgusuToolStripMenuItem_Click);
            // 
            // dgvRaporListesi
            // 
            this.dgvRaporListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaporListesi.Location = new System.Drawing.Point(22, 125);
            this.dgvRaporListesi.Name = "dgvRaporListesi";
            this.dgvRaporListesi.RowHeadersWidth = 51;
            this.dgvRaporListesi.RowTemplate.Height = 24;
            this.dgvRaporListesi.Size = new System.Drawing.Size(728, 279);
            this.dgvRaporListesi.TabIndex = 1;
            // 
            // lblRaporBaslik
            // 
            this.lblRaporBaslik.AutoSize = true;
            this.lblRaporBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRaporBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblRaporBaslik.Location = new System.Drawing.Point(52, 71);
            this.lblRaporBaslik.Name = "lblRaporBaslik";
            this.lblRaporBaslik.Size = new System.Drawing.Size(85, 29);
            this.lblRaporBaslik.TabIndex = 2;
            this.lblRaporBaslik.Text = "label1";
            // 
            // yıllıkSatışlarToolStripMenuItem
            // 
            this.yıllıkSatışlarToolStripMenuItem.Name = "yıllıkSatışlarToolStripMenuItem";
            this.yıllıkSatışlarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.yıllıkSatışlarToolStripMenuItem.Text = "Yıllık Satışlar";
            this.yıllıkSatışlarToolStripMenuItem.Click += new System.EventHandler(this.yıllıkSatışlarToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRaporBaslik);
            this.Controls.Add(this.dgvRaporListesi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satislarSorgusuToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvRaporListesi;
        private System.Windows.Forms.Label lblRaporBaslik;
        private System.Windows.Forms.ToolStripMenuItem yıllıkSatışlarToolStripMenuItem;
    }
}