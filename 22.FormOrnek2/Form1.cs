using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22.FormOrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtIsim.Text);
            txtIsim.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGoster.Enabled = false;
        }

        private void txtIsim_TextChanged(object sender, EventArgs e)
        {
            if (txtIsim.Text==string.Empty)
            {
                btnGoster.Enabled = false;
                txtIsim.Focus();
            }
            else
            {
                btnGoster.Enabled = true;
            }
        }
    }
}
