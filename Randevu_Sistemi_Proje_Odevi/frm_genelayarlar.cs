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
    public partial class frm_genelayarlar : Form
    {
        public frm_genelayarlar()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_gunler where pazartesi=@pazartesi,sali=@sali,carsamba=@carsamba,persembe=@persembe,cuma=@cuma,cumartesi=@cumartesi,pazar=@pazar", bgl.baglanti());
            da.SelectCommand.Parameters.Add("@pazartesi", SqlDbType.Bit).Value = cekPazartesi.Checked;
            da.SelectCommand.Parameters.Add("@sali", SqlDbType.Bit).Value = cekSali.Checked;
            da.SelectCommand.Parameters.Add("@carsamba", SqlDbType.Bit).Value = cekCarsamba.Checked;
            da.SelectCommand.Parameters.Add("@persembe", SqlDbType.Bit).Value = cekPersembe.Checked;
            da.SelectCommand.Parameters.Add("@cuma", SqlDbType.Bit).Value = cekCuma.Checked;
            da.SelectCommand.Parameters.Add("@cumartesi", SqlDbType.Bit).Value = cekCumartesi.Checked;
            da.SelectCommand.Parameters.Add("@pazar", SqlDbType.Bit).Value = cekPazar.Checked;
            bgl.baglanti().Close();
            this.Close();
        }

        private void frm_genelayarlar_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_gunler where pazartesi=@pazartesi,sali=@sali,carsamba=@carsamba,persembe=@persembe,cuma=@cuma,cumartesi=@cumartesi,pazar=@pazar", bgl.baglanti());                
            da.SelectCommand.Parameters.Add("@pazartesi", SqlDbType.Bit).Value = cekPazartesi.Checked;
            da.SelectCommand.Parameters.Add("@sali", SqlDbType.Bit).Value = cekSali.Checked;
            da.SelectCommand.Parameters.Add("@carsamba", SqlDbType.Bit).Value = cekCarsamba.Checked;
            da.SelectCommand.Parameters.Add("@persembe", SqlDbType.Bit).Value = cekPersembe.Checked;
            da.SelectCommand.Parameters.Add("@cuma", SqlDbType.Bit).Value = cekCuma.Checked;
            da.SelectCommand.Parameters.Add("@cumartesi", SqlDbType.Bit).Value = cekCumartesi.Checked;
            da.SelectCommand.Parameters.Add("@pazar", SqlDbType.Bit).Value = cekPazar.Checked;
        }
    }
}
