using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Randevu_Sistemi_Proje_Odevi
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ODA82LS\\SQLEXPRESS;Initial Catalog=RandevuTakipSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
