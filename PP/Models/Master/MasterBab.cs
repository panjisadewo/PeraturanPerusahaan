using PP.Models.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PP.Models.Master
{
    public class MasterBab : CoreBook
    {
        public Int64 Id { get; set; }
        public MasterBook Book { get; set; }
        [ForeignKey("Book")]
        public Nullable<Int64> BookId { get; set; }
        public MasterKelompok Kelompok { get; set; }
        public Nullable<Int64> KelompokId { get; set; }
        public string KomenProgress { get; set; }
        public string KomenTarget { get; set; }
        public string Dokuments { get; set; }
    }
}