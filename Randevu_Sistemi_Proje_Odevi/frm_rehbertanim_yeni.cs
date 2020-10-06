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
    public partial class frm_rehbertanim_yeni : Form
    {
        public frm_rehbertanim_yeni()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_kayitsec(AdiUnvani,İlgili,Kodu,GrupKodu,Gsm,eposta,meslek,adres,tc)values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtilgili.Text);
            komut.Parameters.AddWithValue("@d3", txtkodu.Text);
            komut.Parameters.AddWithValue("@d4", txtgrupkodu.Text);
            komut.Parameters.AddWithValue("@d5", mskgsm.Text);
            komut.Parameters.AddWithValue("@d6", txteposta.Text);
            komut.Parameters.AddWithValue("@d7", txtmeslek.Text);
            komut.Parameters.AddWithValue("@d8", rchadres.Text);
            komut.Parameters.AddWithValue("@d9", mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Hasta Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İptal etmek istediğinizden emin misiniz? ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frm_rehbertanim_yeni_Load(object sender, EventArgs e)
        {
            
            
          
        }

        
    }
}
