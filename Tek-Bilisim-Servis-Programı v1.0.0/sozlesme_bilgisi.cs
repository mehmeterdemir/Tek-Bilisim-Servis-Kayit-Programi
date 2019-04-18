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
    public partial class servis_bilgisi : Form
    {
        public servis_bilgisi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti2 = new SqlConnection(@"Data Source=.;Initial Catalog=sozlesme_goruntu;Integrated Security=True");
        SqlConnection baglanti3 = new SqlConnection(@"Data Source=.;Initial Catalog=firmalar_kaydi;Integrated Security=True");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            firma_ara();
        }
        void firma_ara()
        {
            try
            {
                string baslik = this.Text;
                SqlDataAdapter da = new SqlDataAdapter("Select * from " + comboBox1.Text.ToLower() + " where firma_adi Like '" + comboBox1.Text.ToLower() + "%'", baglanti2);// ½ 
                this.Text = comboBox1.Text;
                DataSet ds = new DataSet();
                baglanti2.Open();
                da.Fill(ds, baslik);
                baglanti2.Close();
                dataGridView1.DataSource = ds.Tables[baslik];
                
            }
            catch (Exception hata)
            {

                MessageBox.Show("Bir Hata Oluştu : "+hata.Message);
                baglanti2.Close();
            }
        }

        private void sozlesme_bilgisi_Load(object sender, EventArgs e)
        {

            Musteri_Adi_Cek();

        }
        void Musteri_Adi_Cek()
        {
            baglanti3.Open();
            DataTable dt = baglanti3.GetSchema("Tables");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["TABLE_NAME"].ToString().Trim().Substring(0, 4) != "MSys")
                {
                    comboBox1.Items.Add(dt.Rows[i]["TABLE_NAME"]);
                }

            }
            baglanti3.Close();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();

        }
    }
}
