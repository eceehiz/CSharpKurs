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

namespace _33.Otel_Form
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
            SqlCommand cmd = new SqlCommand(baglanti.ConnectionString = "Server=localhost; Database=Musteriler; User=sa; Password=Password1");  //komut yazmak için nesne oluşturuyorum

            MusteriListele();
        }

        private void MusteriListele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Musteriler", baglanti); 
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvListe.DataSource = dt;
            dgvListe.Columns[0].Visible = false; //id görünmemesi için
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string adi = txtAd.Text;
            string soyadi = txtSoyad.Text;
            string telNo = mtxtTelNo.Text;
            string eMail = txtMail.Text;
            string tcNo = txtTcNo.Text;
            string uyruk = cbmUyruk.SelectedItem.ToString();

            if (adi == string.Empty || soyadi==string.Empty)
            {
                MessageBox.Show("Lütfen alanları doldurunuz");
            }

            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = string.Format("insert musteriler (Adi, Soyadi, TelNo, EMail, TcNo, Uyruk) values('{0}', '{1}', '{2}','{3}', '{4}', '{5}')", adi, soyadi, telNo, eMail, tcNo, uyruk);

                cmd.Connection = baglanti;
                baglanti.Open();

                int etk = cmd.ExecuteNonQuery(); 
                if (etk > 0)
                {
                    MessageBox.Show("Müşteri Eklendi");
                    MusteriListele();
                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu");
                }

                baglanti.Close();
                txtAd.Text = string.Empty;
                txtSoyad.Text = string.Empty;
                mtxtTelNo.Text = string.Empty;
                txtMail.Text = string.Empty;
                txtTcNo.Text = string.Empty;
                cbmUyruk.Text = string.Empty;

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string adi = txtAd.Text;
            string soyadi = txtSoyad.Text;
            string telNo = mtxtTelNo.Text;
            string eMail = txtMail.Text;
            string tcNo = txtTcNo.Text;
            string uyruk = cbmUyruk.SelectedItem.ToString();

            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("Update musteriler set Adi='{0}', SoyAdi= '{1}' , TelNo='{2}', EMail='{3}', TcNo='{4}', Uyruk='{5}' where MusteriID={6}", adi, soyadi, telNo, eMail, tcNo, uyruk, txtAd.Tag);
            komut.Connection = baglanti;
            baglanti.Open();
            try
            {
                int etk = komut.ExecuteNonQuery();
                if (etk > 0)
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    MusteriListele();
                }
                else
                {
                    MessageBox.Show("Güncelleme Başarısız");
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata sebebi" + ex.Message);
                baglanti.Close();
            }
        }

        private void dgvListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Tag = dgvListe.CurrentRow.Cells["MusteriID"].Value;
            txtAd.Text = dgvListe.CurrentRow.Cells["Adi"].Value.ToString();
            txtSoyad.Text = dgvListe.CurrentRow.Cells["SoyAdi"].Value.ToString();
            mtxtTelNo.Text = dgvListe.CurrentRow.Cells["TelNo"].Value.ToString();
            txtMail.Text= dgvListe.CurrentRow.Cells["EMail"].Value.ToString();
            txtTcNo.Text = dgvListe.CurrentRow.Cells["TcNo"].Value.ToString();
            cbmUyruk.Text = dgvListe.CurrentRow.Cells["Uyruk"].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvListe.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvListe.CurrentRow.Cells["MusteriID"].Value);
                SqlCommand komut = new SqlCommand("delete Musteriler where MusteriID=" + id, baglanti);
                baglanti.Open();
                try
                {
                    int etk = komut.ExecuteNonQuery();
                    if (etk > 0)
                    {
                        MessageBox.Show("Aktif Kayıt Silindi");
                        MusteriListele();

                    }
                    else
                    {
                        MessageBox.Show("Aktif Kayıt SilinEmedi");

                    }
                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Oluştu ", ex.Message);
                    baglanti.Close();
                }
            }
        }
    }
}
