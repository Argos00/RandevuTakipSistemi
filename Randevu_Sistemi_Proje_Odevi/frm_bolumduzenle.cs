using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randevu_Sistemi_Proje_Odevi
{
    public partial class frm_bolumduzenle : Form
    {
        public frm_bolumduzenle()
        {
            InitializeComponent();
        }
        
        frm_anasayfa fr = new frm_anasayfa();
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTumu_Click(object sender, EventArgs e)
        {
            foreach (Control chck in groupBox1.Controls)
            {
                if (chck is CheckBox)
                {
                    if ((chck as CheckBox).Checked == false)
                    {
                        (chck as CheckBox).Checked = true;
                    }
                }
            }
        }
        private void btnSecimYok_Click(object sender, EventArgs e)
        {
            foreach(Control chck  in groupBox1.Controls)
            {
                if (chck is CheckBox)
                {
                    if ((chck as CheckBox).Checked== true)
                    {
                        (chck as CheckBox).Checked = false;
                    }

                }

            }

        }
        frm_anasayfa ana = new frm_anasayfa();

        private void cekBolum1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            
            }

        public void frm_bolumduzenle_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
