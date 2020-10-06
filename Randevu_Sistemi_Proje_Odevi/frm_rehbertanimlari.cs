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
    
    public partial class frm_rehbertanimlari : Form
    {
        public frm_rehbertanimlari()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        // EXCELDEN AKTAR
        public void file()
        {
            openFileDialog1.Filter = "xls files(*.xls)|*.xls|All files(*.*)|*.*";
            openFileDialog1.InitialDirectory = @"C: \";
            openFileDialog1.Title = "lütfen bir excel dosyası seçiniz.";
            openFileDialog1.FileName = " ";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frm_rehbertanim_yeni fr = new frm_rehbertanim_yeni();
            fr.Show();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    frm_rehbertanim_kopyala fr = new frm_rehbertanim_kopyala();
        //    fr.Show();
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            frm_rehbertanim_duzenle fr = new frm_rehbertanim_duzenle();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_rehbertanimlari_Load(object sender, EventArgs e)
        {







            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id,tc,adiunvani,kodu,meslek,grupkodu,ilgili,gsm,eposta,adres from tbl_Kayitsec", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("delete from tbl_kayitsec where id=@b1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@b1", sil.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir blok seçiniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            sil.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnTumunuSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("delete from tbl_kayitsec ", bgl.baglanti());
            
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        // EXCELDEN AKTAR.
        private void btnExceldenAktar_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            file();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //file();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adaptor = new SqlDataAdapter("select id,tc,adiunvani,kodu,meslek,grupkodu,ilgili,gsm,eposta,adres from tbl_kayitsec", bgl.baglanti());
                DataSet ds = new DataSet();
                ds.Clear();
                adaptor.Fill(ds, "tbl_kayitsec");
                dataGridView1.DataSource = ds.Tables["tbl_kayitsec"];
                adaptor.Dispose();


            }
            catch
            {

                return;
            }
        }
    }
}
