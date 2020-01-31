using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PP.Models.Core
{
    public class CoreBook
    {
        public string Nama { get; set; }
        public string Status { get; set; }
        public string Urutan { get; set; }
        public string Created { get; set; }
        public string UpdateDate { get; set; }
        public string Jadwal { get; set; }
        public string NoInstruksi { get; set; }
        public DateTime TanggalBerlaku { get; set; }
        public DateTime TanggalJatuhTempo { get; set; }
        public DateTime TimeLine { get; set; }
        public string StatusProposal { get; set; }
        public Int64 Pencapaian { get; set; }
        public string Target { get; set; }
        public string PercentTarget { get; set; }
        public string KomenProgress { get; set; }
        public string KomenTarget { get; set; }
        public string RejectKomenProgress { get; set; }
        public string RejectKomenTarget { get; set; }
        public string ApproveKomenProgress { get; set; }
        public string ApproveKomenTarget { get; set; }
        public string Baca { get; set; }
    }
}