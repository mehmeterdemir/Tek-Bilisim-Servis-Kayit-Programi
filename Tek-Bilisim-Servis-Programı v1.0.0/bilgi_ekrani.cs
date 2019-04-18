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
    public partial class bilgi_ekrani_sozlesme : Form
    {
        public bilgi_ekrani_sozlesme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=firmalar_kaydi;Integrated Security=True");
        SqlConnection baglanti2 = new SqlConnection(@"Data Source=.;Initial Catalog=servis_;Integrated Security=True");

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa ans = new Anasayfa();
            ans.Show();
            this.Close();
        }

        private void bilgi_ekrani_Load(object sender, EventArgs e)
        {

            Musteri_Adi_Cek ();
        }


        void firma_ara()
        {
            string baslik = this.Text;
            SqlDataAdapter da = new SqlDataAdapter("Select * from " + comboBox1.Text.ToLower() + " where firma_adi Like '" + comboBox1.Text.ToLower() + "%'", baglanti);// ½ 
            this.Text = comboBox1.Text;
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, baslik);
            baglanti.Close();
            dtgBilgi.DataSource = ds.Tables[baslik];
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            firma_ara();
        }
        void Musteri_Adi_Cek()
        {
            baglanti.Open();
            DataTable dt = baglanti.GetSchema("Tables");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["TABLE_NAME"].ToString().Trim().Substring(0, 4) != "MSys")
                {
                    comboBox1.Items.Add(dt.Rows[i]["TABLE_NAME"]);
                }

            }
            baglanti.Close();
        }
    }
}
