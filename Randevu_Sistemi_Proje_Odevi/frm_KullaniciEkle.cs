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
    public partial class frm_KullaniciEkle : Form
    {
        public frm_KullaniciEkle()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_giris (kullaniciadi,sifre) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkullaniciadi.Text);
            komut.Parameters.AddWithValue("@p2", txtşifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            if (txtkullaniciadi.Text == "" && txtşifre.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız!");
            }
            else
            {
                MessageBox.Show("Kullanıcı Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            
        }
    }
}
