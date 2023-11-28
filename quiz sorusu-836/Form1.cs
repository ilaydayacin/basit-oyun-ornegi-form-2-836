using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_sorusu_836
{
    public partial class Form1 : Form
    {
        OyuncuSart oyuncu;
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            btnVur.Enabled = true;
            Random rnd= new Random();
            string rId = rnd.Next(1000, 2000000).ToString();

            oyuncu = new OyuncuSart(rId, txtAd.Text, txtSoyad.Text, txtPosta.Text, 0, DateTime.Now, false);

            if (rbAktif.Checked)
            {
                oyuncu.Aktif = true;
            }
            MessageBox.Show("Kullanıcı eklendi");

            lblbilgi.Text = oyuncu.BilgiYaz();
            lblPuan.Text = "Puan: " + oyuncu.Puan;
            lblDefans.Text = "Defans: " + oyuncu.Defans;

            txtAd.Clear();
            txtSoyad.Clear();
            txtPosta.Clear();
        }

        private void btnHediye_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi = random.Next(1, 101);
            MessageBox.Show("Hediye olarak " + sayi + " Puan");

            lblbilgi.Text = oyuncu.BilgiYaz();
            lblPuan.Text = "Puan: " + sayi;


            txtAd.Clear();
            txtSoyad.Clear();
            txtPosta.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Savaşa doğru oyununa HOŞGELDİN! ");
            MessageBox.Show("Haydi hemen kayıt ol, Ordunun sana İhtiyacı var.");
        }

        private void btnVur_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac < 6)
            {
                Vur(oyuncu);
            }

            if (oyuncu.Defans <= 0)
            {
                MessageBox.Show("Oyuncu Kaybetti");
                btnVur.Enabled = false;
            }
            if (oyuncu.Defans > 0 && sayac == 0)
            {
                MessageBox.Show("Oyuncu kazandı " + oyuncu.Defans + " Kalan defansı");
                btnVur.Enabled = false;
            }

        }

        public void Vur(OyuncuSart oyuncu)
        {
            Random rand=new Random();
            int sayi = rand.Next(0, 26);
            oyuncu.Defans = oyuncu.Defans - sayi;
            MessageBox.Show("verilen hasar: "+sayi);

        }

    }
}
