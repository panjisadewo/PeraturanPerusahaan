using PP.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PP.ViewModels
{
    public class DashboardKelompokVM
    {
        public string NamaKelompok { get; set; }
        public IEnumerable<DashboardVM> book { get; set; }
    }

    public class DashboardVM
    {
        public Int64 Id { get; set; }
        public string NamaBuku { get; set; }
        public IEnumerable<BabVM> bab { get; set; }
    }

    public class BabVM
    {
        public Int64 Id { get; set; }
        public string Urutan { get; set; }
        public string NamaBab { get; set; }
        public IEnumerable<SubBabVM> subbab { get; set; }
    }

    public class SubBabVM {
        public Int64 Id { get; set; }
        public string Urutan { get; set; }
        public string NamaSubBab { get; set; }
        public int countSubSubBab { get; set; }
        public IEnumerable<SubSubBabVM> subsubbab { get; set; }
    }

    public class SubSubBabVM
    {
        public Int64 Id { get; set; }
        public string Urutan { get; set; }
        public string NamaSubSubBab { get; set; }
    }
}