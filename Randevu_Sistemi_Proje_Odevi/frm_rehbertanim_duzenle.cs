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
    public partial class frm_rehbertanim_duzenle : Form
    {
        public frm_rehbertanim_duzenle()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        // GÜNCELLEME
        private void btnKaydet_Click(object sender, EventArgs e)
        {

           
            
                SqlCommand komut = new SqlCommand("update tbl_kayitsec set adiunvani=@p1,ilgili=@p2,kodu=@p3,grupkodu=@p4,gsm=@p5,eposta=@p6,meslek=@p7,adres=@p8 where tc=@p9", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtilgili.Text);
                komut.Parameters.AddWithValue("@p3", txtkodu.Text);
                komut.Parameters.AddWithValue("@p4", txtgrupkodu.Text);
                komut.Parameters.AddWithValue("@p5", mskgsm.Text); 
                komut.Parameters.AddWithValue("@p6", txteposta.Text);
                komut.Parameters.AddWithValue("@p7", txtmeslek.Text);
                komut.Parameters.AddWithValue("@p8", rchadres.Text);

                komut.Parameters.AddWithValue("@p9", mskTC.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Hasta Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
          
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İptal etmek istediğinizden emin misiniz?", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frm_rehbertanim_duzenle_Load(object sender, EventArgs e)
        {
          
        }
    }
}
