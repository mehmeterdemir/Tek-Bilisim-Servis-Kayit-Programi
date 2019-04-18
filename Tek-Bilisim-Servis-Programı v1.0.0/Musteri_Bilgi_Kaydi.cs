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
    public partial class Musteri_Bilgi_Kaydi : Form
    {
        public Musteri_Bilgi_Kaydi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=firmalar_kaydi;Integrated Security=True");
      
        SqlConnection baglanti2 = new SqlConnection(@"Data Source=.;Initial Catalog=sozlesme_goruntu;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Bilgi_Kaydet();
            sozlesme_goruntu_kayit();
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();

        }
        void Bilgi_Kaydet ()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
               
                string kayit = "INSERT INTO "+cmbMusteri.Text+"(firma_adi,bolge,makina_modeli,seri_no,durumu,soz_baslangic,soz_bitis) values (@firma_adi,@bolge,@makina_modeli,@seri_no,@durumu,@soz_baslangic,@soz_bitis)";
             
                SqlCommand komut = new SqlCommand(kayit, baglanti);
               
                komut.Parameters.AddWithValue("@firma_adi", cmbMusteri.SelectedItem);
                komut.Parameters.AddWithValue("@bolge", txtBolge.Text);
                komut.Parameters.AddWithValue("@makina_modeli", txtMakModel.Text);
                komut.Parameters.AddWithValue("@seri_no", txtSeriNo.Text);
                komut.Parameters.AddWithValue("@durumu", cmbDurum.SelectedItem);
                komut.Parameters.AddWithValue("@soz_baslangic", dtpBaslangic.Text);
                komut.Parameters.AddWithValue("@soz_bitis", lblSozBitis.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        void sozlesme_goruntu_kayit()
        {
            try
            {
                if (baglanti2.State == ConnectionState.Closed)
                    baglanti2.Open();

                string kayit = "INSERT INTO soz_goruntule (firma_adi,bolge,makina,seri_no,durumu,soz_bas,soz_bit) values (@firma_adi,@bolge,@makina,@seri_no,@durumu,@soz_bas,@soz_bit)";

                SqlCommand komut = new SqlCommand(kayit, baglanti2);

                komut.Parameters.AddWithValue("@firma_adi", cmbMusteri.SelectedItem);
                komut.Parameters.AddWithValue("@bolge", txtBolge.Text);
                komut.Parameters.AddWithValue("@makina", txtMakModel.Text);
                komut.Parameters.AddWithValue("@seri_no", txtSeriNo.Text);
                komut.Parameters.AddWithValue("@durumu", cmbDurum.SelectedItem);
                komut.Parameters.AddWithValue("@soz_bas", dtpBaslangic.Text);
                komut.Parameters.AddWithValue("@soz_bit", lblSozBitis.Text);
                komut.ExecuteNonQuery();
                baglanti2.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        void Musteri_Adi_Cek()
        {
            baglanti.Open();
            DataTable dt = baglanti.GetSchema("Tables");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["TABLE_NAME"].ToString().Trim().Substring(0, 4) != "MSys")
                {
                    cmbMusteri.Items.Add(dt.Rows[i]["TABLE_NAME"]);
                }
              
            }
            baglanti.Close();
        }

        void labele_cek()
        {
            
            int yil = Convert.ToInt32(dtpBaslangic.Value.Year);
            int yilek = yil + 1;
            int ay = Convert.ToInt32(dtpBaslangic.Value.Month);
            int gun = Convert.ToInt32(dtpBaslangic.Value.Day);

            lblSozBitis.Text = gun.ToString()+"."+ay.ToString()+"."+yilek.ToString();
            
        }

        private void Musteri_Bilgi_Kaydi_Load(object sender, EventArgs e)
        {
            Musteri_Adi_Cek();
            cmbDurum.SelectedIndex = 0;
           
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            labele_cek();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
