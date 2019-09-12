using MvcSyainKanri.Models;
using MvcSyainKanri.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSyainKanri.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new IndexModel();
            ShikakuTable st = new ShikakuTable();
            model.ListShikaku = st.GetShikaku();
            if(Session["Shikaku"] != null)
            {
                Shikaku shikaku = (Shikaku)Session["Shikaku"];
                SyutokuTable syu = new SyutokuTable();
                model.ListSyutokuSyain = syu.GetSyutoku(shikaku);
            }
            else
            {
                model.ListSyutokuSyain = null;
            }
            return View(model);
        }


        public ActionResult selectShikaku(String shikakuName)
        {
            var model = new IndexModel();
            ShikakuTable st = new ShikakuTable();
            model.ListShikaku = st.GetShikaku();
            Shikaku shikaku = new Shikaku();
            shikaku.ShikakuName = shikakuName;
            Session["Shikaku"] = shikaku;
            SyutokuTable syu = new SyutokuTable();
            model.ListSyutokuSyain = syu.GetSyutoku(shikaku);
            return View("Index",model);
        }

        public ActionResult SelectSyosai(String SyainName)
        {
            var model = new SyosaiModel();
            Syain syain = new Syain();
            syain.SyainName = SyainName;
            SyainTable st = new SyainTable();
            model.syosai = st.GetSyain(syain);
            return View("Syosai",model);
        }
    }
}