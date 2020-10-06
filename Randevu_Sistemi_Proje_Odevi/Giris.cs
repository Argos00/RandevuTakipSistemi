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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_giris where kullaniciadi=@p1 and sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkullaniciad.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frm_anasayfa fr = new frm_anasayfa();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
            }
            bgl.baglanti().Close();

        }
    }
}
