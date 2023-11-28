using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_sorusu_836
{
    public class OyuncuSart
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Id { get; set; }
        public int Puan { get; set; }
        public string Eposta { get; set; }
        public bool Aktif { get; set; }
        public DateTime Tarih { get; set; }
        public int Defans { get; set; }

        public OyuncuSart(string id, string ad, string soyad, string eposta, int puan, DateTime KayitTarih, bool Aktifmi)
        {
            Id = id;
            Ad = ad;
            Soyad = soyad;
            Eposta = eposta;
            Puan = puan;
            Tarih = KayitTarih;
            Aktif=Aktifmi;

            DefansArttir();
        }
        public string BilgiYaz()
        {
            return "ID: " + Id + "\nAd: " + Ad
                + "\nSoyad: " + Soyad
                + "\nE posta: " + Eposta
                + "\nKayıt tarihi: " + Tarih
                + "\n Aktif mi: " + Aktif;
        }

        public void DefansArttir()
        {
            Random rnd = new Random();
            Defans = rnd.Next(10,101);
        }

    }
}
