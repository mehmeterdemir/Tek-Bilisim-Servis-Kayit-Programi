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
    public partial class Musteri_Kayit_Ekrani : Form
    {
        public Musteri_Kayit_Ekrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=firmalar_kaydi;Integrated Security=True");
        SqlConnection baglanti2 = new SqlConnection(@"Data Source=.;Initial Catalog=servis_girisi;Integrated Security=True");
        SqlConnection baglanti3 = new SqlConnection(@"Data Source=.;Initial Catalog=sozlesme_takip;Integrated Security=True");
        SqlConnection baglanti4 = new SqlConnection(@"Data Source=.;Initial Catalog=servis_goruntuleme;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            Musteri_Olustur();
            servis_olustur();
            sozlesme_olustur();
            Musteri_Bilgi_Kaydi musteri_Bilgi = new Musteri_Bilgi_Kaydi();
            musteri_Bilgi.Show();
            this.Close();
        }

        private void Musteri_Kayit_Ekrani_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }
        void Musteri_Olustur()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Create Table " + textBox1.Text + "(firma_adi varchar(70),bolge varchar(50),makina_modeli varchar(50),seri_no varchar(50),durumu varchar(40),soz_baslangic varchar(30),soz_bitis varchar(30))", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Oluşturdu");

                if (baglanti != null && baglanti.State == ConnectionState.Closed)
                {

                    baglanti.Open();
                }
            }
            catch (Exception istisna)
            {

                MessageBox.Show("Müşteri Oluşturulurken Bir Hata Oluştu : " + istisna.Message);
                baglanti.Close();
            }
        }

        void servis_olustur()
        {
            try
            {
                baglanti2.Open();
                SqlCommand komut = new SqlCommand("Create Table " + textBox1.Text + "(firma_adi varchar(70),tarih varchar(30),durumu varchar(50),ariza varchar(1000),yapilan_islem varchar(1000),birim_bolum varchar(1000),model_seri varchar(1000),degisen_malzeme varchar(1000),degismesi_gereken_malzeme varchar(1000),bolge varchar(50),numarator varchar(100),sistem varchar(50),tek_bilisim_adina varchar(70),musteri_yet varchar(70))", baglanti2);
                komut.ExecuteNonQuery();
                baglanti2.Close();


                if (baglanti2 != null && baglanti2.State == ConnectionState.Closed)
                {

                    baglanti2.Open();
                }
            }
            catch (Exception istisna)
            {

                MessageBox.Show("Servis Oluşturulurken Bir Hata Oluştu : " + istisna.Message);
                baglanti2.Close();
            }


           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        void sozlesme_olustur()
        {
            try
            {
                baglanti3.Open();
                SqlCommand komut = new SqlCommand("Create Table " + textBox1.Text + "(firma_adi varchar(70),bolge varchar(50),makina_modeli varchar(50),seri_no varchar(50),durumu varchar(40),soz_baslangic varchar(30),soz_bitis varchar(30))", baglanti3);
                komut.ExecuteNonQuery();
                baglanti3.Close();
              

                if (baglanti3 != null && baglanti3.State == ConnectionState.Closed)
                {

                    baglanti3.Open();
                }
            }
            catch (Exception istisna)
            {

                MessageBox.Show("Sozlesme Oluşturulurken Bir Hata Oluştu : " + istisna.Message);
                baglanti3.Close();
            }

        }
    }
}
