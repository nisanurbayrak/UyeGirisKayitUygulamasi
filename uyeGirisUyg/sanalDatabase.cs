using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyeGirisUyg
{
    class sanalDatabase
    {
        public static List<kullanici> KullaniciTablo = new List<kullanici>();
        static sanalDatabase()
        {
            KullaniciTablo.Add(new kullanici()
            {
                kullaniciAd = "Bulbasaur",
                ad = "Bulbasaur",
                sıraNo = 1,
                renk = "Yeşil",
                sifre = "001",
                //aciklama = "Hoşgeldin"
            });

            KullaniciTablo.Add(new kullanici()
            {
                kullaniciAd = "Pikachu",
                ad = "Pikachu",
                sıraNo = 25,
                renk = "Sarı",
                sifre = "025",
                // aciklama = "Hoşgeldin"
            });

            //uyeOl uye = new uyeOl();
            //uye.Ekle();

            KullaniciEkle();
        }

        public static void KullaniciEkle()
        {
            uyeOl uye1 = new uyeOl();
            //uye1.Ekle();
            KullaniciTablo.Add(new kullanici()
            {
                kullaniciAd = uye1.kullaniciAd.Text,
                ad = uye1.adi.Text,
                sifre = uye1.sifre.Text,
                renk = uye1.renk.Text
            });
        }
    }
}
