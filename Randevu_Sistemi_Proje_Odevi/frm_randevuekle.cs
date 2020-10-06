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
    public partial class frm_randevuekle : Form
    {
        public frm_randevuekle()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

       

        private void frm_randevuekle_Load(object sender, EventArgs e)
        {
            


            SqlCommand komut5 = new SqlCommand("select sekiltanim from tbl_randevusekil", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                cmbrandevusekil.Items.Add(dr5[0]);
            }
            SqlCommand komut6 = new SqlCommand("select randevunedeni from tbl_randevunedenitanimlari", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                cmbrandevuneden.Items.Add(dr6[0]);
            }
            SqlCommand komut7 = new SqlCommand("select birim from tbl_birimtanimlari", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                cmbbirim.Items.Add(dr7[0]);
            }
            SqlCommand komut8 = new SqlCommand("select sonuc from tbl_sonuctanimlari", bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                cmbsonuc.Items.Add(dr8[0]);
            }
            SqlCommand komut9 = new SqlCommand("select durum from tbl_durumtanimlari", bgl.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                cmbDurum.Items.Add(dr9[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into tbl_kayitsec (adiunvani,kodu,meslek,grupkodu,ilgili,gsm,eposta,adres,randevusekil,Durum,Sonuc,Birim,Gorusme,Adet,Tahsilat,Bakiye,RandevuNeden,Notlar,tc,tarih,kayitbilgi,duzenleme) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p22,@p23,@p24,@p25)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtkodu.Text);
            komut.Parameters.AddWithValue("@p3", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p4", txtGrupKodu.Text);
            komut.Parameters.AddWithValue("@p5", txtilgili.Text);
            komut.Parameters.AddWithValue("@p6", mskgsm.Text);
            komut.Parameters.AddWithValue("@p7", txteposta.Text);
            komut.Parameters.AddWithValue("@p8", rchadres.Text);
            komut.Parameters.AddWithValue("@p9", cmbrandevusekil.Text);
            komut.Parameters.AddWithValue("@p10", cmbDurum.Text);
            komut.Parameters.AddWithValue("@p11", cmbsonuc.Text);
            komut.Parameters.AddWithValue("@p12", cmbbirim.Text);
            komut.Parameters.AddWithValue("@p13", txtGorusme.Text);
            komut.Parameters.AddWithValue("@p14", mskAdet.Text);
            komut.Parameters.AddWithValue("@p15", mskTahsilat.Text);
            komut.Parameters.AddWithValue("@p16", mskBakiye.Text);
            komut.Parameters.AddWithValue("@p17", cmbrandevuneden.Text);
            komut.Parameters.AddWithValue("@p18", rchnotlar.Text);
            komut.Parameters.AddWithValue("@p22", mskTC.Text);
            komut.Parameters.AddWithValue("@p23", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@p24", txtkayitbilgi.Text);
            komut.Parameters.AddWithValue("@p25", txtDuzenleme.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cmbrandevusekil.Text = " ";
            txtGorusme.Text = " ";
            cmbsonuc.Text = " ";
            mskAdet.Text = " ";
            mskTahsilat.Text = " ";
            mskBakiye.Text = " ";
            cmbDurum.Text = " ";
            rchnotlar.Text = " ";
            txtAd.Text = " ";
            txtkodu.Text = " ";
            txtMeslek.Text = " ";
            mskgsm.Text = " ";
            txteposta.Text = " ";
            rchadres.Text = " ";
            mskTC.Text = " ";
            txtGrupKodu.Text = " ";
            txtilgili.Text = " ";
            cmbrandevuneden.Text = " ";
            cmbbirim.Text = " ";
            txtkayitbilgi.Text = " ";
            txtDuzenleme.Text = " ";
            cmbrandevusekil.Focus();
            
            


            }

        private void numErteleme_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void btniptal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İptal etmek istediğinizden emin misiniz? ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
    }
    
    
