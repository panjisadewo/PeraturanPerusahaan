using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PP.Models.Master
{
    public class MasterAktivitas
    {
        public Int64 Id { get; set; }
        public string Nama { get; set; }
        public string Percent { get; set; }
        public string Hari { get; set; }
    }
}