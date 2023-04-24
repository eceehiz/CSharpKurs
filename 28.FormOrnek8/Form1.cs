using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28.FormOrnek8
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        decimal ek;
        private void Form1_Load(object sender, EventArgs e)
        {
            Ebat kucuk = new Ebat { Adi = "Küçük", Carpan = 1 };
            Ebat orta = new Ebat { Adi = "Orta", Carpan = 1.25 };
            Ebat buyuk = new Ebat { Adi = "Büyük", Carpan = 1.75 };
            Ebat maxi = new Ebat { Adi = "Maxi", Carpan = 2 };
            comboBox1.Items.Add(kucuk); //bu adımda metodu ezmeye ebat classa git
            comboBox1.Items.Add(orta);
            comboBox1.Items.Add(buyuk);
            comboBox1.Items.Add(maxi);

            KenarTip ince = new KenarTip { Adi = "İnce Kenar", EkFiyat = 0 };
            radioButton1.Tag = ince;
            KenarTip kalin = new KenarTip { Adi = "Kalın Kenar", EkFiyat = 2 };
            radioButton2.Tag = kalin;
            ek = kalin.EkFiyat;

            Pizza klasik = new Pizza { Adi = "Klasik", Fiyat = 80 };
            Pizza karma = new Pizza { Adi = "Karma", Fiyat = 100 };
            Pizza turkish = new Pizza { Adi = "Turkish", Fiyat = 200 };
            Pizza tuna = new Pizza { Adi = "Tuna", Fiyat = 120 };
            Pizza akdeniz = new Pizza { Adi = "Akdeniz", Fiyat = 100 };
            Pizza karadeniz = new Pizza { Adi = "Karadeniz", Fiyat = 150 };
            listBox1.Items.Add(klasik);
            listBox1.Items.Add(karma);
            listBox1.Items.Add(turkish);
            listBox1.Items.Add(tuna);
            listBox1.Items.Add(akdeniz);
            listBox1.Items.Add(karadeniz);

        }

        class Ebat
        {
            public string Adi { get; set; }
            public double Carpan { get; set; }
            public override string ToString()
            {
                return Adi;
            }
        }

        class KenarTip
        {
            public string Adi { get; set; }
            public decimal EkFiyat { get; set; }
        }

        class Pizza
        {
            public string Adi { get; set; }
            public decimal Fiyat { get; set; }
            public Ebat Ebati { get; set; }
            public KenarTip Kenari { get; set; }
            public List<string> Malzemeler { get; set; }

            public decimal Tutar
            {
                get
                {
                    decimal tutar = 0;
                    tutar = Fiyat * (decimal)Ebati.Carpan;
                    tutar += Kenari.EkFiyat;

                    return tutar;
                }

            }
            public override string ToString()
            {
                return Adi;
            }
        }

        class Siparis
        {
            public Pizza Pizzam { get; set; }
            public int Adet { get; set; }
            public decimal ToplamTutar { get; set; }
            public override string ToString()
            {
                string spr = "";
                spr += Pizzam.Ebati.Adi + ",";
                spr += Pizzam.Adi + ",";
                spr += Pizzam.Kenari.Adi + ",";
                foreach (string mlz in Pizzam.Malzemeler)
                {
                    spr += string.Format("{0},", mlz);
                }
                spr += string.Format("{0}x{1}={2}", Adet, Pizzam.Tutar, Adet * Pizzam.Tutar);
                return spr;
            }

        }


        private void button1_Click(object sender, EventArgs e) //hesapla butonu
        {
            // Pizza pz = listBox1.SelectedItem as Pizza; yada 

            Pizza p = (Pizza)listBox1.SelectedItem;

            p.Ebati = comboBox1.SelectedItem as Ebat;
            p.Kenari = radioButton1.Checked ? (KenarTip)radioButton1.Tag : (KenarTip)radioButton2.Tag;

            p.Malzemeler = new List<string>();

            foreach (CheckBox ctrl in groupBox1.Controls)
            {
                if (ctrl.Checked)
                {
                    p.Malzemeler.Add(ctrl.Text);
                }
            }

            decimal tutar = numericUpDown1.Value * p.Tutar;

            textBox1.Text = tutar.ToString();

            sprs = new Siparis();
            sprs.Pizzam = p;
            sprs.Adet = (int)numericUpDown1.Value;

        }

        Siparis sprs;
        private void button2_Click(object sender, EventArgs e) //sepete ekle butonu
        {
            if (sprs != null)
            {
                listBox2.Items.Add(sprs);
            }

        }

        private void button3_Click(object sender, EventArgs e) //siparişi onayla butonu
        {
            decimal toplamTutar = 0;
            int adet = 0; //mesaj boxta yazacak adet için

            foreach (Siparis spr in listBox2.Items)
            {
                toplamTutar += spr.Adet * spr.Pizzam.Tutar;
                adet++;
            }
            label6.Text = toplamTutar.ToString();

            MessageBox.Show("Toplam sipariş adediniz: " + adet + "\nToplam sipariş tutarınız: " + toplamTutar);

        }
    }
}
