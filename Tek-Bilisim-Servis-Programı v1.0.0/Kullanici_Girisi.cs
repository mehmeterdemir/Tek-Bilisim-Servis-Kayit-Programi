using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;


namespace Tek_Bilisim_Servis_Programı_v1._0._0
{
    public partial class Kullanici_Girisi : Form
    {
        public Kullanici_Girisi()
        {
            InitializeComponent();
        }
       

    SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=kullanici;Integrated Security=True");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string KullaniciGirisi = Interaction.InputBox("Yeni Kullanıcı Kaydı İçin Yönetici Şifresi Girmelisiniz");
            if (KullaniciGirisi == "090618079")
            {
                Kullanici_Kayit_Ekrani kulkayit = new Kullanici_Kayit_Ekrani();
                kulkayit.ShowDialog();

            }
            else
            {
                MessageBox.Show("YÖNETİCİ ŞİFRESİ YANLIŞ!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        void kontrol() {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
          
            SqlCommand komut = new SqlCommand("select *from kullanicilar where kullanici_adi='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                Anasayfa fr1 = new Anasayfa(); 
                fr1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre hatalı !!! ");
                baglanti.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kontrol();
        }
    }

       
    
}
