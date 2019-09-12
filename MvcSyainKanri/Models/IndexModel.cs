using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace MvcSyainKanri.Models
{
    public class IndexModel
    {
        public DataTable ListShikaku { set; get; }
        public DataTable ListSyutokuSyain { set; get; }
    }
}