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
    public partial class Frm_DurumTanimlari : Form
    {
        public Frm_DurumTanimlari()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void Frm_DurumTanimlari_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from tbl_durumtanimlari", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_durumtanimlari (DURUM) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskbirim.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Durum Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("delete from tbl_durumtanimlari where durum=@b1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@b1", sil.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Durum Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen silmek istediğiniz sütunu seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            sil.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
