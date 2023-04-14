using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21.FormOrnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMerhaba_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba, hoşgeldin");
        }

        private void btnIsim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İsmim: Ece");
        }

        private void btnIsımDegis_Click(object sender, EventArgs e)
        {
            btnIsımDegis.Text = "selam texti, merhaba olarak değiştirildi";
        }

        private void lblTurkiye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void lblTR_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            lblTR.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTR.ForeColor = Color.White;
            this.BackColor = Color.Red;

        }

       
    }




}
