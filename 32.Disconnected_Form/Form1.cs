﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Server=.; Database=Northwind; user=sa; password=Password1");
        private void Form1_Load(object sender, EventArgs e)
        {
            UrunListele();

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txtUrunAdi.Visible = true;
            nudFiyat.Visible = true;
            nudStok.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            txtKategoriAdi.Visible = false;
            txtTanimi.Visible = false;
            btnKategoriEkle.Visible = true;
            btnKategoriEkle.Visible = false;
            btnGuncelle.Visible = true;


        }

        private void UrunListele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from urunler", baglanti); //data readerdan fakı: açma kapama yapmıyoruz. select komutu için geçerli
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvListe.DataSource = dt;
            dgvListe.Columns["UrunID"].Visible = false;  //görmek istemediğimiz kolonları bu şekilde kapatıyoruz
            dgvListe.Columns["KategoriID"].Visible = false;
            dgvListe.Columns["TedarikciID"].Visible = false;


            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txtUrunAdi.Visible = true;
            nudFiyat.Visible = true;
            nudStok.Visible = true;
            btnEkle.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            txtKategoriAdi.Visible = false;
            txtTanimi.Visible = false;
            btnKategoriEkle.Visible = false;

        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriListele();

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            txtUrunAdi.Visible = false;
            nudFiyat.Visible = false;
            nudStok.Visible = false;
            btnEkle.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            txtKategoriAdi.Visible = true;
            txtTanimi.Visible = true;
            btnKategoriEkle.Visible = true;



        }

        private void KategoriListele()
        {
            //dgvListe.RowTemplate.Height = 150;
            SqlDataAdapter adp = new SqlDataAdapter("select * from kategoriler", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvListe.DataSource = dt;
        }

        private void urunlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adi = txtUrunAdi.Text;
            decimal fiyat = nudFiyat.Value;
            decimal stok = nudStok.Value;

            if (adi == string.Empty || fiyat == 0 || stok == 0)
            {
                MessageBox.Show("Lütfen alanları doldurunuz");
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("insert urunler (UrunAdi, BirimFiyati, HedefStokDuzeyi) values('{0}', {1}, {2})", adi, fiyat, stok);
                cmd.Connection = baglanti;
                baglanti.Open();
                int etk = cmd.ExecuteNonQuery(); //etkilenen
                if (etk > 0)
                {
                    MessageBox.Show("Kayıt Eklendi");
                    UrunListele();
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu");
                }
                baglanti.Close();
                txtUrunAdi.Text = string.Empty;
                nudFiyat.Value = 0;
                nudFiyat.Value = 0;
            }



        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            string adi = txtKategoriAdi.Text;
            string tanimi = txtTanimi.Text;
            if (adi == string.Empty || tanimi == string.Empty)
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz");
            }
            else
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = string.Format("insert into kategoriler (KategoriAdi, Tanimi) values ('{0}','{1}')", adi, tanimi);
                komut.Connection = baglanti;
                baglanti.Open();
                int etk = komut.ExecuteNonQuery();
                if (etk > 0)
                {
                    MessageBox.Show("İşlem başarılı");
                    KategoriListele();

                }
                else
                {
                    MessageBox.Show("Bir hata oluştu");
                }
                baglanti.Close();
            }

        }

        private void faturalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select MusteriName, UrunAdi, BirimFiyati*Miktar*(1-İndirim) as Tutar from Faturalar", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvListe.DataSource = dt;
        }

        private void dgvListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Tag = dgvListe.CurrentRow.Cells["UrunID"].Value;
            txtUrunAdi.Text = dgvListe.CurrentRow.Cells["UrunAdi"].Value.ToString();
            nudFiyat.Value = (decimal)dgvListe.CurrentRow.Cells["BirimFiyati"].Value;
            nudStok.Value = Convert.ToDecimal(dgvListe.CurrentRow.Cells["HedefStokDuzeyi"].Value.ToString());
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string adi = txtUrunAdi.Text;
            int fiyat = (int)nudFiyat.Value;
            decimal stok = nudStok.Value;

            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("Update urunler set UrunAdi='{0}', BirimFiyati= {1} , HedefStokDuzeyi={2} where UrunID={3}", adi, fiyat, stok, txtUrunAdi.Tag);
            komut.Connection = baglanti;
            baglanti.Open();
            try
            {
                int etk = komut.ExecuteNonQuery();
                if (etk > 0)
                {
                    MessageBox.Show("Güncelleme başarılı");
                    UrunListele();
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız");
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata sebebi" + ex.Message);
                baglanti.Close();
            }


        }
    }
}
