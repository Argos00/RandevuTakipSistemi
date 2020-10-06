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
    public partial class frm_FirmaEkle : Form
    {
        public frm_FirmaEkle()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_firma(firmakodu,firmaunvani) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtfirmakod.Text);
            komut.Parameters.AddWithValue("@p2", txtfirmaunvan.Text); 
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            if (txtfirmakod.Text == "" && txtfirmaunvan.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız!");
            }
            else
            {
                MessageBox.Show("Firma Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void frm_FirmaEkle_Load(object sender, EventArgs e)
        {
           

            
        }
    }
}
