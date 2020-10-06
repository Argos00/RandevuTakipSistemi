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
using System.IO;

namespace Randevu_Sistemi_Proje_Odevi
{
    
    public partial class frm_anasayfa : Form
    {

        SqlDataAdapter da6;
        DataTable tablo;
        public frm_anasayfa()
        {
            InitializeComponent();
        }




        sqlbaglanti bgl = new sqlbaglanti();
        private void genelAyarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_genelayarlar fr = new frm_genelayarlar();
            fr.ShowDialog();
        }

        private void rehberTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rehbertanimlari fr = new frm_rehbertanimlari();
            fr.ShowDialog();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_hakkinda fr = new frm_hakkinda();
            fr.ShowDialog();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void randevuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_randevuekle fr = new frm_randevuekle();
            fr.ShowDialog();
        }

        private void bölümSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_bolumduzenle fr = new frm_bolumduzenle();
            fr.ShowDialog();
        }



            
        public void frm_anasayfa_Load(object sender, EventArgs e)
        {

            



            SqlCommand komut21 = new SqlCommand("select * from tbl_kayitsec durum where='" + cmbdurum.Text+ "'", bgl.baglanti());



            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Kayitsec", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;


            DataTable dt2= new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select id,tc,tarih,adiunvani,durum,randevuneden from tbl_Kayitsec", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;


            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("select kodu,grupkodu,ilgili,randevusekil from tbl_Kayitsec", bgl.baglanti());
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;




            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("select gsm,eposta,adres,kayitbilgi from tbl_Kayitsec", bgl.baglanti());
            da4.Fill(dt4);
            dataGridView4.DataSource = dt4;



            lbl_saat.Text = DateTime.Now.ToLongTimeString();
            lbl_tarih.Text = DateTime.Now.ToLongDateString();

            SqlCommand komut9 = new SqlCommand("select durum from tbl_durumtanimlari", bgl.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                cmbdurum.Items.Add(dr9[0]);
            }
            ///////////////////////////////////////////////
            da6= new SqlDataAdapter("select * from tbl_kayitsec",bgl.baglanti());
            tablo = new DataTable();
            da6.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bgl.baglanti().Close();




           
        }

        private void sonuçTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sonuctanimlari fr = new frm_sonuctanimlari();
            fr.ShowDialog();
        }

        private void birimTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BirimTanimlari birim = new Frm_BirimTanimlari();
            birim.ShowDialog();
        }

        private void durumTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DurumTanimlari durum = new Frm_DurumTanimlari();
            durum.ShowDialog();
        }

        private void randevuŞekliTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RandevuSekliTanimlari randevusekil = new Frm_RandevuSekliTanimlari();
            randevusekil.ShowDialog();
        }

        private void randevuNedeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RandevuNedeniTanimlari randevuneden = new Frm_RandevuNedeniTanimlari();
            randevuneden.ShowDialog();
        }

        private void kullanıcıTanımlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_KullaniciTanimlari kullanici = new Frm_KullaniciTanimlari();
            kullanici.ShowDialog();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Show();
            dataGridView3.Hide();
            dataGridView4.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView3.Show();
            dataGridView4.Hide();
            dataGridView2.Hide();

        }

        private void btnBolum3_Click(object sender, EventArgs e)
        {
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Show();
        }

        private void bölüm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Show();
            dataGridView3.Hide();
            dataGridView4.Hide();
        }

        private void bölüm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dataGridView3.Show();
            dataGridView4.Hide();
            dataGridView2.Hide();
        }

        private void bölüm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Show();
        }

        private void tümüToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView2.Show();
            dataGridView3.Show();
            dataGridView4.Show();
        }

        private void randevuGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlDataAdapter adaptor = new SqlDataAdapter("select id,tc,tarih,adiunvani,durum,randevuneden from tbl_kayitsec", bgl.baglanti());
                DataSet ds = new DataSet();
                ds.Clear();
                adaptor.Fill(ds, "tbl_kayitsec");
                dataGridView2.DataSource = ds.Tables["tbl_kayitsec"];
                adaptor.Dispose();
  

            }
            catch 
            {

                return;
            }


            try
            {
                SqlDataAdapter adaptor = new SqlDataAdapter("select kodu,grupkodu,ilgili,randevusekil   from tbl_kayitsec", bgl.baglanti());
                DataSet ds = new DataSet();
                ds.Clear();
                adaptor.Fill(ds, "tbl_kayitsec");
                dataGridView3.DataSource = ds.Tables["tbl_kayitsec"];
                adaptor.Dispose();


            }
            catch
            {

                return;
            }

            try
            {
                SqlDataAdapter adaptor = new SqlDataAdapter("select  gsm,eposta,adres,kayitbilgi  from tbl_kayitsec", bgl.baglanti());
                DataSet ds = new DataSet();
                ds.Clear();
                adaptor.Fill(ds, "tbl_kayitsec");
                dataGridView4.DataSource = ds.Tables["tbl_kayitsec"];
                adaptor.Dispose();


            }
            catch
            {

                return;
            }


        }

        private void notlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Notlar not = new frm_Notlar();
            not.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("delete from tbl_kayitsec where id=@b1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@b1", sil.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir blok seçiniz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            sil.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // RANDEVULARI İKİ TARİH ARASINI VEREREK FİLTRELEME
            DataView dv = tablo.DefaultView;
            dv.RowFilter = string.Format("tarih > '{0}' AND tarih <='{1}'", dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.DataSource = dv;
            
        }

        private void bugünToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                
        }

        private void tümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adaptor = new SqlDataAdapter("select * from tbl_kayitsec", bgl.baglanti());
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

        private void şirketimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SirketBilgi fr = new frm_SirketBilgi();
            fr.ShowDialog();
        }

        private void randevuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("delete from tbl_kayitsec where id=@b1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@b1", lbl_silme.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir blok seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            lbl_silme.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
        
        private void cmbdurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter bul = new SqlDataAdapter("select * from tbl_kayitsec where durum=@durum", bgl.baglanti());
            bul.SelectCommand.Parameters.AddWithValue("@durum", cmbdurum.Text);
            bul.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }

        private void bölümTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter adaptor = new SqlDataAdapter("select * from tbl_kayitsec", bgl.baglanti());
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
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = tablo.DefaultView;
            dv.RowFilter = " AdiUnvani LIKE '" + textBox1.Text + "%'";
            dataGridView1.DataSource = dv;


            
        }
        Frm_BirimTanimlari bbb = new Frm_BirimTanimlari();


     
    private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkCyan;
            panel1.BackColor = Color.DarkCyan;
            panel2.BackColor = Color.DarkCyan;
            panel3.BackColor = Color.DarkCyan;
            menuStrip1.BackColor = Color.DarkKhaki;
            menuStrip2.BackColor = Color.DarkKhaki;
            menuStrip4.BackColor = Color.DarkKhaki;
            tabPage1.BackColor = Color.DarkKhaki;
            tabPage2.BackColor = Color.DarkKhaki;
            dataGridView1.BackgroundColor = Color.SlateBlue;
            dataGridView2.BackgroundColor = Color.SlateBlue;
            dataGridView3.BackgroundColor = Color.SlateBlue;
            dataGridView4.BackgroundColor = Color.SlateBlue;
           
            
            


        }
        frm_hakkinda hk = new frm_hakkinda();
        public void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
            panel1.BackColor = Color.DarkGray;
            panel2.BackColor = Color.DarkGray;
            panel3.BackColor = Color.DarkGray;
            menuStrip1.BackColor = Color.Crimson;
            menuStrip2.BackColor = Color.Crimson;
            menuStrip4.BackColor = Color.Crimson;
            tabPage1.BackColor = Color.Crimson;
            tabPage2.BackColor = Color.Crimson;
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView2.BackgroundColor = Color.Snow;
            dataGridView3.BackgroundColor = Color.Snow;
            dataGridView4.BackgroundColor = Color.Snow;
            

          
           
        }
    }
    }

