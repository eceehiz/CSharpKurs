using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32.Disconnected_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=.; Database=Northwind; user=sa; password=Password1");

        private void satislarSorgusuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from [Satislar Sorgusu]", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvRaporListesi.DataSource = dt;

            lblRaporBaslik.Text = satislarSorgusuToolStripMenuItem.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblRaporBaslik.Text = "Raporlar";
        }

        private void yıllıkSatışlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from [Ozet Yillik Satislar]", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvRaporListesi.DataSource = dt;

            lblRaporBaslik.Text = yıllıkSatışlarToolStripMenuItem.Text;
        }
    }
}
