using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tek_Bilisim_Servis_Programı_v1._0._0
{
    public partial class Kullanici_Kayit_Ekrani : Form
    {
        public Kullanici_Kayit_Ekrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=kullanici;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (txteposta.Text == txtepostatekrar.Text && txtsifre.Text == txtsiretekrar.Text)
            {
                kullanici_kaydet();
            }
            else if (txteposta.Text !=txtepostatekrar.Text)
            {
                MessageBox.Show("Lütfen Geçerli E-Posta Adresinizi Tekrar Girin");
            }
            else if (txtsifre.Text != txtsiretekrar.Text)
            {
                MessageBox.Show("Lütfen İki Alana Da Aynı Şifreyi Girin");
            }
          
        }

        void kullanici_kaydet()
        {
            if (txtisim.Text != null && txtsoy.Text != null && txtkuladi.Text != null && txteposta.Text != null && txtsifre.Text != null && txtsiretekrar.Text != null && txtepostatekrar.Text != null)
            {


                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();

                    string kayit = "INSERT INTO kullanicilar (isim,soyisim,kullanici_adi,eposta,sifre) values (@isim,@soyisim,@kullanici_adi,@eposta,@sifre)";

                    SqlCommand komut = new SqlCommand(kayit, baglanti);

                    komut.Parameters.AddWithValue("@isim", txtisim.Text);
                    komut.Parameters.AddWithValue("@soyisim", txtsoy.Text);
                    komut.Parameters.AddWithValue("@kullanici_adi", txtkuladi.Text);
                    komut.Parameters.AddWithValue("@eposta", txteposta.Text);
                    komut.Parameters.AddWithValue("@sifre", txtsifre.Text);

                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("KULLANICI KAYDI GERÇEKLEŞTİ");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Kullanıcı Kaydı İşlemi Sırasında Hata Oluştu." + hata.Message);
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN BOŞ ALAN BIRAKMAYIN!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kullanici_Kayit_Ekrani_Load(object sender, EventArgs e)
        {
            
        }
    }
}
