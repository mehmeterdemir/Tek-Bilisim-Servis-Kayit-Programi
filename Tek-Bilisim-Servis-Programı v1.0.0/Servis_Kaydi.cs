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
    public partial class Servis_Kaydi : Form
    {
        public Servis_Kaydi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=NIRVANA\SQLEXPRESS;Initial Catalog=servis_girisi;Integrated Security=True");
        SqlConnection baglanti2 = new SqlConnection(@"Data Source=NIRVANA\SQLEXPRESS;Initial Catalog=servis_goruntuleme;Integrated Security=True");
        private void Servis_Kaydi_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Musteri_Adi_Cek();
            cmbDurum.SelectedIndex =0;

        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            servis_kaydet();
            listele();
            txtAriza.Text = null;
            txtBirimBolum.Text = null;
            txtBolge.Text = null;
            txtBuro.Text = null;
            txtDegisenMalzeme.Text = null;
            txtDegismesiGereken.Text = null;
            txtModel.Text = null;
            txtMusteriYet.Text = null;
            txtNumarator.Text = null;
            txtYapilan.Text = null;
            cmbDurum.Text = null;
            txtAriza.Text = null;
            txtAriza.Text = null;
            txtAriza.Text = null;
            txtAriza.Text = null;
            txtAriza.Text = null;
            txtAriza.Text = null;
        }
        int k;
        string secili;
        void servis_kaydet()
        {
            
            
         
            for (int k = 0; k < (chkSistem.Items.Count ); k++)
            {
                if (chkSistem.GetItemChecked(k))
                {
                    secili = secili +  chkSistem.Items[k].ToString() + " - ";
                }


            }
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string kayit = "INSERT INTO " + cmbMusteri.Text + "(firma_adi,tarih,durumu,ariza,yapilan_islem,birim_bolum,model_seri,degisen_malzeme,degismesi_gereken_malzeme,bolge,numarator,sistem,tek_bilisim_adina,musteri_yet) values (@firma_adi,@tarih,@durumu,@ariza,@yapilan_islem,@birim_bolum,@model_seri,@degisen_malzeme,@degismesi_gereken_malzeme,@bolge,@numarator,@sistem,@tek_bilisim_adina,@musteri_yet)";

                SqlCommand komut = new SqlCommand(kayit, baglanti);
               

                komut.Parameters.AddWithValue("@firma_adi", cmbMusteri.SelectedItem);
                komut.Parameters.AddWithValue("@tarih", dtpTarih.Text);
                komut.Parameters.AddWithValue("@durumu", cmbDurum.SelectedItem);
                komut.Parameters.AddWithValue("@ariza", txtAriza.Text);
                komut.Parameters.AddWithValue("@yapilan_islem", txtYapilan.Text);
                komut.Parameters.AddWithValue("@birim_bolum", txtBirimBolum.Text);
                komut.Parameters.AddWithValue("@model_seri", txtModel.Text);
                komut.Parameters.AddWithValue("@degisen_malzeme", txtDegisenMalzeme.Text);
                komut.Parameters.AddWithValue("@degismesi_gereken_malzeme", txtDegismesiGereken.Text);
                komut.Parameters.AddWithValue("@bolge", txtBolge.Text);
                komut.Parameters.AddWithValue("@numarator", txtNumarator.Text);
                komut.Parameters.AddWithValue("@sistem", secili);
                komut.Parameters.AddWithValue("@tek_bilisim_adina", txtBuro.Text);
                komut.Parameters.AddWithValue("@musteri_yet", txtMusteriYet.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Servis Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Servis Kaydı İşlemi Sırasında Hata Oluştu." + hata.Message);
            }
        }

        //private void btnGoster_Click(object sender, EventArgs e)
        //{

        //    if (cmbMusteri.Text != null)
        //    {
        //        listele();
        //    }
        //    else
        //    {
        //        MessageBox.Show("LÜTFEN LİSTELEMEK İÇİN ÖNCE MÜŞTERİ SEÇİN", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }


        //}
        void servis_gor_kaydet()
        {



            for (int k = 0; k < (chkSistem.Items.Count); k++)
            {
                if (chkSistem.GetItemChecked(k))
                {
                    secili = secili + chkSistem.Items[k].ToString() + " - ";
                }


            }
            try
            {
                if (baglanti2.State == ConnectionState.Closed)
                    baglanti2.Open();

                string kayit = "INSERT INTO " + cmbMusteri.Text + "(firma_adi,tarih,durum,ariza,yapilan_islem,birim_bolum,model_seri,degisen_malzeme,degismesi_gereken_malzeme,bolge,numarator,sistem,tek_bil_adina,musteri_yetkilisi) values (@firma_adi,@tarih,@durum,@ariza,@yapilan_islem,@birim_bolum,@model_seri,@degisen_malzeme,@degismesi_gereken_malzeme,@bolge,@numarator,@sistem,@tek_bil_adina,@musteri_yetkilisi)";

                SqlCommand komut = new SqlCommand(kayit, baglanti2);


                komut.Parameters.AddWithValue("@firma_adi", cmbMusteri.SelectedItem);
                komut.Parameters.AddWithValue("@tarih", dtpTarih.Text);
                komut.Parameters.AddWithValue("@durum", cmbDurum.SelectedItem);
                komut.Parameters.AddWithValue("@ariza", txtAriza.Text);
                komut.Parameters.AddWithValue("@yapilan_islem", txtYapilan.Text);
                komut.Parameters.AddWithValue("@birim_bolum", txtBirimBolum.Text);
                komut.Parameters.AddWithValue("@model_seri", txtModel.Text);
                komut.Parameters.AddWithValue("@degisen_malzeme", txtDegisenMalzeme.Text);
                komut.Parameters.AddWithValue("@degismesi_gereken_malzeme", txtDegismesiGereken.Text);
                komut.Parameters.AddWithValue("@bolge", txtBolge.Text);
                komut.Parameters.AddWithValue("@numarator", txtNumarator.Text);
                komut.Parameters.AddWithValue("@sistem", secili);
                komut.Parameters.AddWithValue("@tek_bil_adina", txtBuro.Text);
                komut.Parameters.AddWithValue("@musteri_yetkilisi", txtMusteriYet.Text);
                komut.ExecuteNonQuery();
                baglanti2.Close();
                MessageBox.Show("Servis Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Servis Kaydı İşlemi Sırasında Hata Oluştu." + hata.Message);
                baglanti2.Close();
            }

        }
        void listele()
        {
            firma_ara();
            SqlDataAdapter da = new SqlDataAdapter("Select * from " + cmbMusteri.Text.ToLower() + " where firma_adi Like '" + cmbMusteri.Text.ToLower() + "%'", baglanti);
            string baslik = this.Text;
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, baslik);
            baglanti.Close();
            dgListele.DataSource = ds.Tables[baslik];
        }
        void firma_ara()
        {
            string baslik = this.Text;
            SqlDataAdapter da = new SqlDataAdapter("Select * from " + cmbMusteri.Text.ToLower() + " where firma_adi Like '" + cmbMusteri.Text.ToLower() + "%'", baglanti);// ½ 
            this.Text = cmbMusteri.Text;
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, baslik);
            baglanti.Close();
            dgListele.DataSource = ds.Tables[baslik];
        }

       
        void duzelt()
        {
            baglanti.Open();
            string kayit = "update "+cmbMusteri.Text+ " set firma_adi=@firma_adi,tarih=@tarih,durumu=@durumu,ariza=@ariza,yapilan_islem=@yapilan_islem,birim_bolum=@birim_bolum,model_seri=@model_seri,degisen_malzeme=@degisen_malzeme,degismesi_gereken_malzeme=@degismesi_gereken_malzeme,bolge=@bolge,numarator=@numarator,sistem=@sistem,tek_bilisim=@tek_bilisim,musteri_yet=@musteri_yet where musterino=@musterino";
            // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            komut.Parameters.AddWithValue("@firma_adi", cmbMusteri.Text);
            komut.Parameters.AddWithValue("@tarih", dtpTarih.Text);
            komut.Parameters.AddWithValue("@durumu", cmbDurum.Text);
            komut.Parameters.AddWithValue("@ariza", txtAriza.Text);
            komut.Parameters.AddWithValue("@yapilan_islem",txtYapilan.Text);
            komut.Parameters.AddWithValue("@birim_bolum", txtBirimBolum.Text);
            komut.Parameters.AddWithValue("@model_seri", txtModel.Text);
            komut.Parameters.AddWithValue("@degisen_malzeme", txtDegisenMalzeme.Text);
            komut.Parameters.AddWithValue("@degismesi_gereken_malzeme", txtDegismesiGereken.Text);
            komut.Parameters.AddWithValue("@bolge", txtBolge.Text);
            komut.Parameters.AddWithValue("@numarator", txtNumarator.Text);
            komut.Parameters.AddWithValue("@sistem", chkSistem.SelectedItems.ToString());
            komut.Parameters.AddWithValue("@tek_bilisim", txtBuro.Text);
            komut.Parameters.AddWithValue("@musteri_yet", txtMusteriYet.Text);

            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            komut.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            baglanti.Close();
            MessageBox.Show("Servis Bilgileri Güncellendi.");
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

        private void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void chkSistem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMusteriYet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDegismesiGereken_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDegisenMalzeme_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYapilan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAriza_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkSistem_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNumarator_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBolge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBirimBolum_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMusteri_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listele();
        }

        private void dgListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtAriza.Text.Length != 0)
            {
                txtAriza.BackColor = Color.Green;
            }
            else
            {
                txtAriza.BackColor = Color.Gray;
            }
            if (txtBirimBolum.Text.Length != 0)
            {
                txtBirimBolum.BackColor = Color.Green;
            }
            else
            {
                txtBirimBolum.BackColor = Color.Gray;
            }
            if (txtBolge.Text.Length != 0)
            {
                txtBolge.BackColor = Color.Green;
            }
            else
            {
                txtBolge.BackColor = Color.Gray;
            }
            if (txtBuro.Text.Length != 0)
            {
                txtBuro.BackColor = Color.Green;
            }
            else
            {
                txtBuro.BackColor = Color.Gray;
            }
            if (txtDegisenMalzeme.Text.Length != 0)
            {
                txtDegisenMalzeme.BackColor = Color.Green;
            }
            else
            {
                txtDegisenMalzeme.BackColor = Color.Gray;
            }
            if (txtDegismesiGereken.Text.Length != 0)
            {
                txtDegismesiGereken.BackColor = Color.Green;
            }
            else
            {
                txtDegismesiGereken.BackColor = Color.Gray;
            }
            if (txtModel.Text.Length != 0)
            {
                txtModel.BackColor = Color.Green;
            }
            else
            {
                txtModel.BackColor = Color.Gray;
            }
            if (txtMusteriYet.Text.Length != 0)
            {
                txtMusteriYet.BackColor = Color.Green;
            }
            else
            {
                txtMusteriYet.BackColor = Color.Gray;
            }
            if (txtNumarator.Text.Length != 0)
            {
                txtNumarator.BackColor = Color.Green;
            }
            else
            {
                txtNumarator.BackColor = Color.Gray;
            }
            if (txtYapilan.Text.Length != 0)
            {
                txtYapilan.BackColor = Color.Green;
            }
            else
            {
                txtYapilan.BackColor = Color.Gray;
            }
          
        }
    }
}
