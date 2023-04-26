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

namespace _30.ConnectedMimari_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection();  //sql e bağlandık

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(baglanti.ConnectionString = "Server=localhost; Database=Northwind; User=sa; Password=Password1");  //komut yazmak için nesne oluşturuyorum
            
            UrunListele();
            KategoriListele();
            TedarikcileriListele();

        }
        private void UrunListele()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Urunler";  //komutu yazdık. bu sorguyu consolda bir üstteki parantezin içinde yazmıştık, bu sefer tek satırda yapmadık böyle yaptık

            cmd.Connection = baglanti;
            baglanti.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())  //ilk satırın tamamını okuyo
            {
                string adi = reader["UrunAdi"].ToString();
                string fiyat = reader["BirimFiyati"].ToString();
                string stok = reader["HedefStokDuzeyi"].ToString();
                lstUrunler.Items.Add(string.Format("{0}-{1}-{2}", adi, fiyat, stok));
            }

            baglanti.Close();
        }

        private void KategoriListele()
        {
            SqlCommand cmd = new SqlCommand("select * from Kategoriler", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lstKategoriler.Items.Add(reader[1].ToString());
            }
            baglanti.Close();
        }

        private void TedarikcileriListele()
        {
            SqlCommand cmd = new SqlCommand("select * from Tedarikciler", baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lstTedarikciler.Items.Add(reader[1].ToString());
            }
            baglanti.Close();
        }
    }
}
