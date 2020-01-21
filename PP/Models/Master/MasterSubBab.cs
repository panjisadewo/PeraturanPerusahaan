using PP.Models.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PP.Models.Master
{
    public class MasterSubBab : CoreBook
    {
        public Int64 Id { get; set; }
        public MasterBab Bab { get; set; }
        [ForeignKey("Bab")]
        public Nullable<Int64> BabId { get; set; }
        public string Dokuments { get; set; }
    }
}