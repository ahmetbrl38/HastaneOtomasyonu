using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneOtomasyonu
{

    class sqlBaglantisi
    {

        public SqlConnection baglanti() {

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-7I9J2B9;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        
        }



    }
}
