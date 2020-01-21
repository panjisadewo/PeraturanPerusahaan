using PP.Models.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PP.Models.Master
{
    public class MasterSubSubBab : CoreBook
    {
        public Int64 Id { get; set; }
        public MasterSubBab SubBab { get; set; }
        [ForeignKey("SubBab")]
        public Nullable<Int64> SubBabId { get; set; }
        public string Dokuments { get; set; }
        public string statusApproved { get; set; }
    }
}