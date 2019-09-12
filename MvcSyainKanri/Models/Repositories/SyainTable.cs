using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MvcSyainKanri.Models.Repositories
{
    public class SyainTable
    {
        public Syain GetSyain(Syain syain)
        {
            string cstr = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(cstr))
            {
                string sql = "select * from Syain where SyainName = @syainName ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.Parameters.Add("@syainName", SqlDbType.VarChar);
                adapter.SelectCommand.Parameters["@syainName"].Value = syain.SyainName;

                DataSet ds = new DataSet();
                int cnt = adapter.Fill(ds, "Syain");
                if (cnt != 0)
                {
                    DataTable dt = ds.Tables["Syain"];
                    syain.SyainNo = dt.Rows[0]["SyainNo"].ToString();
                    syain.Seibetsu = dt.Rows[0]["Seibetsu"].ToString();
                    syain.NyusyaDate = DateTime.Parse(dt.Rows[0]["NyusyaDate"].ToString());
                    syain.Kihonkyu = int.Parse( dt.Rows[0]["Kihonkyu"].ToString());
                    syain.Photo = dt.Rows[0]["Photo"].ToString();
                    syain.Taisyoku = (bool)dt.Rows[0]["Taisyoku"];
                }
            }
            return syain;
        }

    }
}