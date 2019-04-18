using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tek_Bilisim_Servis_Programı_v1._0._0
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("ÇIKMAK İSTEDİĞİNİZE EMİN MİSİNİZ ? ", "Uyarı", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (cikis == DialogResult.No)
            {
               
            }
        }

        private void yENİMÜŞTERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteri_Kayit_Ekrani mstr = new Musteri_Kayit_Ekrani();
            mstr.ShowDialog();
            

        }

        private void vAROLANMÜŞTERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bilgi_ekrani_sozlesme bilgi_soz = new bilgi_ekrani_sozlesme();
            
            bilgi_soz.Show();
            this.Hide();


        }

        private void sERVİSİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servis_Kaydi srv = new Servis_Kaydi();
            srv.ShowDialog();
            this.Hide();

        }

        private void sÖZLEŞMETAKİBİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bilgi_ekrani_sozlesme sz = new bilgi_ekrani_sozlesme();
            sz.Show();
            sz.Text = "SOZLEŞME BİLGİ EKRANI";
            this.Hide();
        }

        private void sERVİSBİLGİSİGÖRÜNTÜLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            servis_bilgisi servis = new servis_bilgisi();
            servis.Show();
            servis.Text = "SERVİS BİLGİ EKRANI";
            
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start ("chrome.exe", "http://tekbilisimburo.com/");
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void tOSHİBAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "http://business.toshiba.com/support/");
        }

        private void tEKBİLİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "http://tekbilisimburo.com/");
        }

        private void Anasayfa_Load( object sender, EventArgs e )
        {

        }
    }
}
