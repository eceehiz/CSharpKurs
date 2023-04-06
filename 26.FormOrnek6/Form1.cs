using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26.FormOrnek6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            lblSaniye.Text = sayac.ToString();

            lblSaniye.Text = saniye < 10 ? string.Format("0{0}", saniye) : lblSaniye.Text = saniye.ToString();
            saniye++;

            if (saniye>59)
            {
                dakika++;

                if (dakika>59)
                {
                    saat++;
                    lblSaat.Text = saat < 10 ? string.Format("0{0}", saat) : lblSaat.Text = saat.ToString();
                    dakika = 0;
                }


                lblDakika.Text = dakika < 10 ? string.Format("0{0}", dakika) : lblDakika.Text = dakika.ToString();
                saniye = 0;
            }



        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
            
        }

        int saniye = 0; int dakika=0;  int saat = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
