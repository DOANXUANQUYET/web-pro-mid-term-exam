using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SyainKanri
{
    public class ShikakuTable
    {
        public DataTable GetShikaku()
        {
            DataTable dt = null;
            string cstr = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(cstr))
            {
                string sql = "SELECT * FROM Shikaku";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Shikaku");
                dt = ds.Tables["Shikaku"];
            }
            return dt;
        }
    }
}