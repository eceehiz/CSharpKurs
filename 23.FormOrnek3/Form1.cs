using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23.FormOrnek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            if (txtbxSayi1.Text == string.Empty)
            {
                txtbxSayi1.Text = "0";
               
            }

            if (txtbxSayi2.Text==string.Empty)
            {
                txtbxSayi2.Text = "0";
            }

            int sayi1= Convert.ToInt32(txtbxSayi1.Text);
            int sayi2 = Convert.ToInt32(txtbxSayi2.Text);
            int sonuc = sayi1 + sayi2;
            MessageBox.Show($"{sonuc}");

            lblSonuc2.Text = sonuc.ToString();

        }

        private void txtbxSayi1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtbxSayi2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
