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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            string kAd = textBoxNick.Text;
            string kSifre = textBoxSifre.Text;
            kullanici bulunanKullanici = sanalDatabase.KullaniciTablo.Find(i => i.kullaniciAd == kAd && i.sifre == kSifre);
            if (bulunanKullanici != null)
            {
                mainForm ana = new mainForm(bulunanKullanici);
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş!", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }


        }


        private void textBoxNick_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.YellowGreen;
        }

        private void textBoxNick_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            uyeOl uye = new uyeOl();
            uye.Show();
        }

        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {
            textBoxSifre.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNick_TextChanged(object sender, EventArgs e)
        {

        }

        private void nicklbl_Click(object sender, EventArgs e)
        {

        }

        private void sfrelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
