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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=.; Database=Northwind; user=sa; password=Password1");

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Urunler", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvListe.DataSource = dt;
            dgvListe.Columns[0].Visible = false;
            dgvListe.Columns[2].Visible = false;
            dgvListe.Columns[3].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert Urunler(UrunAdi, BirimFiyati, HedefStokDuzeyi) values(@adi, @fiyat, @stok)";

            /*eğer sql de hazır prosedür varsa
             SqlCommand cmd = new SqlCommand("UrunEkle", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@urunAdi", txtUrunAd.Text);
            cmd.Parameters.AddWithValue("@fiyat", nudFiyat.Value);
            cmd.Parameters.AddWithValue("@stok", nudStok.Value);

            */

            cmd.Connection = baglanti;
            cmd.Parameters.AddWithValue("@adi", txtUrunAd.Text);
            cmd.Parameters.AddWithValue("@fiyat", nudFiyat.Value);
            cmd.Parameters.AddWithValue("@stok", nudStok.Value);

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

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            Kategoriler ktgForm = new Kategoriler();
            ktgForm.ShowDialog();
        }

        private void btnTedarikciler_Click(object sender, EventArgs e)
        {
            Tedarikciler tdrForm = new Tedarikciler();
            tdrForm.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvListe.CurrentRow!=null)
            {
                SqlCommand cmd = new SqlCommand("UrunSil", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@urunAdi", dgvListe.CurrentRow.Cells["urunAdi"].Value);
                baglanti.Open();

                int etk = cmd.ExecuteNonQuery();
                baglanti.Close();

                if (etk > 0)
                {
                    MessageBox.Show("Silindi");
                    Listele();
                }
                else
                {
                    MessageBox.Show("Silinemedi");
                }


            }
        }
    }
}
