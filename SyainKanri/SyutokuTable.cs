using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SyainKanri
{
    public class SyutokuTable
    {
        public DataTable GetSyutoku(Shikaku shikaku)
        {
            DataTable dt = null;
            string cstr = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(cstr))
            {
                string sql = "select SyainName,SyutokuYM from Syutoku st inner join Syain sy on st.SyainNo = sy.SyainNo" +
                    " where ShikakuNo = (select ShikakuNo from Shikaku where ShikakuName = @shiname);";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.Parameters.Add("@shiname", SqlDbType.VarChar);
                adapter.SelectCommand.Parameters["@shiname"].Value = shikaku.ShikakuName;

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Syutoku");
                dt = ds.Tables["Syutoku"];
            }
            return dt;
        }
    }
}