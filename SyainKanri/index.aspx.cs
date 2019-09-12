using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SyainKanri
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShikakuTable tb = new ShikakuTable();
            dltShikaku.DataSource = tb.GetShikaku();
            dltShikaku.DataBind();
            if (Session["Shikaku"] != null)
            {
                Shikaku shikaku = (Shikaku)Session["Shikaku"];
                SyutokuTable st = new SyutokuTable();
                lblShikakuName.Text = shikaku.ShikakuName;
                dltSyain.DataSource = st.GetSyutoku(shikaku);
                dltSyain.DataBind();
            }
        }

        protected void lbtShikakuName_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            Shikaku shikaku = new Shikaku();
            shikaku.ShikakuName = lb.CommandArgument;
            SyutokuTable st = new SyutokuTable();
            lblShikakuName.Text = lb.CommandArgument;
            Session["Shikaku"] = shikaku;
            dltSyain.DataSource = st.GetSyutoku(shikaku);
            dltSyain.DataBind();
        }

        protected void lbtSyainName_Click(object sender, EventArgs e)
        { 
            LinkButton lb = (LinkButton)sender;
            Syain syain = new Syain();
            syain.SyainName = lb.CommandArgument;
            Session["Syain"] = syain;
            Server.Transfer("syosai.aspx");
        }

        protected void lbtSyutokuYM_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            Syain syain = new Syain();
            syain.SyainName = lb.CommandArgument;
            Session["Syain"] = syain;
            Server.Transfer("syosai.aspx");
        }
    }
}