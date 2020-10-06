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

namespace Randevu_Sistemi_Proje_Odevi
{
    public partial class frm_SirketBilgi : Form
    {
        public frm_SirketBilgi()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            frm_FirmaEkle fr = new frm_FirmaEkle();
            fr.ShowDialog();
        }

        private void frm_SirketBilgi_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_firma", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_firma(firmakodu,firmaunvani) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız!");
            }
            else
            {
                MessageBox.Show("Firma Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("delete from tbl_firma where firmakodu=@b1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@b1", sil.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Firma Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir sütun seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
