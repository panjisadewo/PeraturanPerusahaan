using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PP.Models.Master
{
    public class MasterSummarySubBab
    {
        public Int64 Id { get; set; }
        public string HasilReview { get; set; }
        public string Updating { get; set; }
        public string DasarUpdating { get; set; }
        public string AcuanUpdating { get; set; }
        public string Sebelum { get; set; }
        public string Sesudah { get; set; }
        public string DasarPenyusunan { get; set; }
        public MasterBab SubBab { get; set; }
        [ForeignKey("SubBab")]
        public Nullable<Int64> SubBabId { get; set; }
    }
}