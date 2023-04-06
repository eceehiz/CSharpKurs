
namespace _21.FormOrnek1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMerhaba = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIsımDegis = new System.Windows.Forms.Button();
            this.btnIsim = new System.Windows.Forms.Button();
            this.lblTurkiye = new System.Windows.Forms.Label();
            this.lblTR = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMerhaba
            // 
            this.btnMerhaba.BackColor = System.Drawing.Color.Red;
            this.btnMerhaba.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnMerhaba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMerhaba.Location = new System.Drawing.Point(21, 36);
            this.btnMerhaba.Name = "btnMerhaba";
            this.btnMerhaba.Size = new System.Drawing.Size(127, 37);
            this.btnMerhaba.TabIndex = 0;
            this.btnMerhaba.Text = "MerhabaTusu";
            this.btnMerhaba.UseVisualStyleBackColor = false;
            this.btnMerhaba.Click += new System.EventHandler(this.btnMerhaba_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIsımDegis);
            this.groupBox1.Controls.Add(this.btnIsim);
            this.groupBox1.Controls.Add(this.btnMerhaba);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 199);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tuslar";
            // 
            // btnIsımDegis
            // 
            this.btnIsımDegis.Location = new System.Drawing.Point(21, 142);
            this.btnIsımDegis.Name = "btnIsımDegis";
            this.btnIsımDegis.Size = new System.Drawing.Size(196, 29);
            this.btnIsımDegis.TabIndex = 4;
            this.btnIsımDegis.Text = "selam";
            this.btnIsımDegis.UseVisualStyleBackColor = true;
            // 
            // btnIsim
            // 
            this.btnIsim.Location = new System.Drawing.Point(9, 79);
            this.btnIsim.Name = "btnIsim";
            this.btnIsim.Size = new System.Drawing.Size(266, 33);
            this.btnIsim.TabIndex = 3;
            this.btnIsim.Text = "İsmimi öğrenmek için tıkla";
            this.btnIsim.UseVisualStyleBackColor = true;
            this.btnIsim.Click += new System.EventHandler(this.btnIsim_Click);
            // 
            // lblTurkiye
            // 
            this.lblTurkiye.AutoSize = true;
            this.lblTurkiye.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTurkiye.Location = new System.Drawing.Point(334, 138);
            this.lblTurkiye.Name = "lblTurkiye";
            this.lblTurkiye.Size = new System.Drawing.Size(0, 45);
            this.lblTurkiye.TabIndex = 3;
            this.lblTurkiye.Click += new System.EventHandler(this.lblTurkiye_Click);
            // 
            // lblTR
            // 
            this.lblTR.AutoSize = true;
            this.lblTR.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTR.Location = new System.Drawing.Point(222, 306);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(102, 37);
            this.lblTR.TabIndex = 4;
            this.lblTR.Text = "Türkiye";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 538);
            this.Controls.Add(this.lblTR);
            this.Controls.Add(this.lblTurkiye);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMerhaba;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIsim;
        private System.Windows.Forms.Button btnIsımDegis;
        private System.Windows.Forms.Label lblTurkiye;
        private System.Windows.Forms.Label lblTR;
    }
}

