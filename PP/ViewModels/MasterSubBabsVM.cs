using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PP.ViewModels
{
    public class SubBabSubBabVM
    {
        public Int64 Id { get; set; }
        public string NamaKelompok { get; set; }
        public string Nama{ get; set; }
        public string Dokuments{ get; set; }
        public string NoInstruksi { get; set; }
        public DateTime TanggalBerlaku { get; set; }
        public DateTime TanggalJatuhTempo { get; set; }
        public DateTime TimeLine { get; set; }
        public string StatusProposal { get; set; }
        public string Urutan { get; set; }
        public string Baca { get; set; }
        public string Pencapaian { get; set; }
        public string NamaPencapaian { get; set; }
        public string Target { get; set; }
        public string PercentTarget { get; set; }
        public int CountDay { get; set; }
        public string Hari { get; set; }
        public Int64 AverageTarget { get; set; }
        public Int64 AveragePencapaian { get; set; }
    }
}