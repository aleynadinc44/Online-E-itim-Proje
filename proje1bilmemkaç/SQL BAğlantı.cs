using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;


namespace proje1bilmemkaç
{
    public class SQLBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-6Q32OA4J\SQLEXPRESS;Initial Catalog=onlineegitimsistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}