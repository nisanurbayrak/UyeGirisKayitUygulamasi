using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyeGirisUyg
{
    public partial class uyeOl : Form
    {

        public uyeOl()
        {
            InitializeComponent();
            
        }

        public void btnkayit_Click(object sender, EventArgs e)
        {
            Ekle();
            sanalDatabase.KullaniciEkle();
            MessageBox.Show("Kayıt Başarılı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        public void Ekle()
        {
            sanalDatabase.KullaniciTablo.Add(new kullanici()
            {
                kullaniciAd = kullaniciAd.Text,
                sifre = sifre.Text,
                ad = adi.Text,
                renk = renk.Text,
            });
        }
    }
}
