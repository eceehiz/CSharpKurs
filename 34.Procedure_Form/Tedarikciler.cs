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

namespace _34.Procedure_Form
{
    public partial class Tedarikciler : Form
    {
        public Tedarikciler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=.; Database=Northwind; user=sa; password=Password1");
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert Tedarikciler(SirketAdi, MusteriAdi) values(@sirket, @musteri)";

            cmd.Connection = baglanti;
            cmd.Parameters.AddWithValue("@sirket", txtSirket.Text);
            cmd.Parameters.AddWithValue("@musteri", txtMusteri.Text);

            baglanti.Open();
            int etk = cmd.ExecuteNonQuery();
            baglanti.Close();

            if (etk > 0)
            {
                MessageBox.Show("Başarılı");
                Listele();

            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }

        private void Tedarikciler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Tedarikciler", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvListe.DataSource = dt;

        }
    }
}
