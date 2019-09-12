using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSyainKanri.Models.Repositories
{
    public class Syain
    {
        public string SyainNo { set; get; }
        public string SyainName { set; get; }
        public string Seibetsu { set; get; }
        public DateTime NyusyaDate { set; get; }
        public int Kihonkyu { set; get; }
        public string Photo { get; set; }
        public bool Taisyoku { get; set; }
    }
}