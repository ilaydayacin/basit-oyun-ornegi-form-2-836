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
            oyuncu = new OyuncuSart();
            Random rnd= new Random();

            oyuncu.Ad = txtAd.Text;
            oyuncu.Soyad = txtSoyad.Text;
            oyuncu.Eposta=txtPosta.Text;
            oyuncu.Puan = "0";
            oyuncu.Id = rnd.Next(1,1000000);
            oyuncu.Tarih = DateTime.Now;
            oyuncu.Aktif = false;
            if (rbAktif.Checked)
            {
                oyuncu.Aktif = true;
            }
            sayac++;
            MessageBox.Show("Kullanıcı eklendi");

            lbKullanici.Items.Add(sayac + ". Oyuncu");
            lbKullanici.Items.Add("ID: " + oyuncu.Id);
            lbKullanici.Items.Add("Adı: "+oyuncu.Ad);
            lbKullanici.Items.Add("Soyad: " + oyuncu.Soyad);
            lbKullanici.Items.Add("E posta: " + oyuncu.Eposta);
            lbKullanici.Items.Add("Kayıt tarihi: " + oyuncu.Tarih);
            lbKullanici.Items.Add("Puan: " + oyuncu.Puan);
            lbKullanici.Items.Add("Aktif mi: " + oyuncu.Aktif);

            txtAd.Clear();
            txtSoyad.Clear();
            txtPosta.Clear();
        }

        private void btnHediye_Click(object sender, EventArgs e)
        {
            lbKullanici.Items.Clear();
            Random random = new Random();
            int sayi = random.Next(1, 101);
            MessageBox.Show("Hediye olarak " + sayi + " Puan");

            lbKullanici.Items.Add(sayac + ". Oyuncu");
            lbKullanici.Items.Add("ID: " + oyuncu.Id);
            lbKullanici.Items.Add("Adı: " + oyuncu.Ad);
            lbKullanici.Items.Add("Soyad: " + oyuncu.Soyad);
            lbKullanici.Items.Add("E posta: " + oyuncu.Eposta);
            lbKullanici.Items.Add("Kayıt tarihi: " + oyuncu.Tarih);
            lbKullanici.Items.Add("Puan: " + sayi);
            lbKullanici.Items.Add("Aktif mi: " + oyuncu.Aktif);


            txtAd.Clear();
            txtSoyad.Clear();
            txtPosta.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Savaşa doğru oyununa HOŞGELDİN! ");
            MessageBox.Show("Haydi hemen kayıt ol, Ordunun sana İhtiyacı var.");
        }
    }
}
