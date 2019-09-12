using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SyainKanri
{
    public partial class syosai : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack){
                Syain syain = (Syain)Session["Syain"];
                SyainTable tb = new SyainTable();
                syain = tb.GetSyain(syain);
                lblSyainNo.Text = syain.SyainNo;
                lblSyainName.Text = syain.SyainName;
                lblSeibetsu.Text = syain.Seibetsu;
                lblNyusyaDate.Text = syain.NyusyaDate.ToLongDateString();
                lblKihonkyu.Text = " \\ " + syain.Kihonkyu;
                lblTaisyoku.Text = syain.Taisyoku ? "退職" : "";
                imgPhoto.ImageUrl = "images/" + syain.Photo;

            }
        }

        protected void btnModoru_Click(object sender, EventArgs e)
        {
            Server.Transfer("index.aspx");
        }
    }
}