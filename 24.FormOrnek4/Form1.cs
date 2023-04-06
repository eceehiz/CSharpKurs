using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24.FormOrnek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1 = 0, sayi2 = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = string.Empty;
            }
            lblSonuc.Text = lblSonuc.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = string.Empty;
            }
            lblSonuc.Text = lblSonuc.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = string.Empty;
            }
            lblSonuc.Text = lblSonuc.Text + btn3.Text;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = string.Empty;
            }
            lblSonuc.Text = lblSonuc.Text + btn4.Text;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = string.Empty;
            }
            lblSonuc.Text = lblSonuc.Text + btn5.Text;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = string.Empty;
            }
            lblSonuc.Text = lblSonuc.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = string.Empty;
            }
            lblSonuc.Text = lblSonuc.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = string.Empty;
            }
            lblSonuc.Text = lblSonuc.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = string.Empty;
            }
            lblSonuc.Text = lblSonuc.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = string.Empty;
            }
            lblSonuc.Text = lblSonuc.Text + btn0.Text;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = string.Empty;
            }
            lblSonuc.Text = lblSonuc.Text + btn00.Text;
        }

        private void btnnokta_Click(object sender, EventArgs e)
        {
            if (lblSonuc.Text == "0")
            {
                lblSonuc.Text = string.Empty;
            }
            lblSonuc.Text = lblSonuc.Text + btnnokta.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = string.Empty;
        }

        private void btnArti_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(lblSonuc.Text);
            lblSonuc.Text = string.Empty;
        }

        private void btnCarpi_Click(object sender, EventArgs e)
        {

        }
        string islem;
        private void btnEsittir_Click(object sender, EventArgs e)
        {
            if (islem == "+")
            {
                sayi2 = Convert.ToInt32(lblSonuc.Text);
                int Toplam = sayi1 + sayi2;

                lblSonuc.Text = Toplam.ToString();
            }

        }
    }
}
