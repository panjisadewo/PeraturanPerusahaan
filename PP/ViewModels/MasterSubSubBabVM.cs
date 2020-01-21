using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PP.ViewModels
{
    public class MasterSubSubBabVM
    {
        public Int64 Id { get; set; }
        public string NamaKelompok { get; set; }
        public string Nama { get; set; }
        public string NoInstruksi { get; set; }
        public DateTime TanggalBerlaku { get; set; }
        public DateTime TanggalJatuhTempo { get; set; }
        public DateTime TimeLine { get; set; }
        public string StatusProposal { get; set; }
        public string Urutan { get; set; }
        public string Baca { get; set; }
    }
}