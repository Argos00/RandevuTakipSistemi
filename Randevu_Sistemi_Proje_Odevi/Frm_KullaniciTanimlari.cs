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
    public partial class Frm_KullaniciTanimlari : Form
    {
        public Frm_KullaniciTanimlari()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void Frm_KullaniciTanimlari_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from tbl_giris", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            frm_KullaniciEkle ekle = new frm_KullaniciEkle();
            ekle.ShowDialog();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("delete from tbl_giris where kullaniciadi=@b1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@b1", sil.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kullanıcı Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir sütun seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            sil.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
