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
    public partial class mainForm : Form
    {
        public mainForm()
        {
        }

        public mainForm(kullanici bulunanKullanici)
        {
            InitializeComponent();
            adi.Text = bulunanKullanici.ad;
            renk.Text = bulunanKullanici.renk;
            aciklama.Text = ("Hoşgeldin "+ adi.Text);
            kullaniciAdi.Text = bulunanKullanici.kullaniciAd;
            kullaniciAdi.Enabled = false;
            sifre.Text = bulunanKullanici.sifre;
            guncellebtn.Tag = bulunanKullanici.sıraNo;
        }

        private void anaForm_Load(object sender, EventArgs e)
        {

        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            // Button btnGuncelle = (Button)sender;
            int sıraNo = (int)guncellebtn.Tag;
            int index = sanalDatabase.KullaniciTablo.FindIndex(i => i.sıraNo == sıraNo);

            sanalDatabase.KullaniciTablo[index].ad = adi.Text;
            sanalDatabase.KullaniciTablo[index].renk = renk.Text;
            sanalDatabase.KullaniciTablo[index].sifre = sifre.Text;
            sanalDatabase.KullaniciTablo[index].aciklama = aciklama.Text;

            MessageBox.Show("Güncelleme Başarılı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
