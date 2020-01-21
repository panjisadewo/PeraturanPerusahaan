using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PP.ViewModels
{
    public class BabBabVM
    {
        public Int64 Id { get; set; }
        public string Urutan { get; set; }
        public string Nama { get; set; }
        public string NamaBuku { get; set; }
        public string Dokument { get; set; }
        public string NamaKelompok { get; set; }
        public DateTime? TanggalBerlaku { get; set; }
        public DateTime? TimeLine { get; set; }
        public DateTime? TanggalJatuhTempo { get; set; }
        public string StatusProposal { get; set; }
        public string NoInstruksi { get; set; }
        public int countBab { get; set; }
    }
}