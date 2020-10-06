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
    public partial class frm_rehbertanim_kopyala : Form
    {
        public frm_rehbertanim_kopyala()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void btnIptal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İptal etmek istediğinizden emin misiniz? ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frm_rehbertanim_kopyala_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("select birim from tbl_birimtanimlari", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbilgili.Items.Add(dr2[0]);
            }
            SqlCommand komut3 = new SqlCommand("select Sonuc from tbl_sonuctanimlari", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbkodu.Items.Add(dr3[0]);
            }
            SqlCommand komut4 = new SqlCommand("select durum from tbl_durumtanimlari", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                cmbgrupkodu.Items.Add(dr4[0]);
            }
            bgl.baglanti().Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
    }
}
