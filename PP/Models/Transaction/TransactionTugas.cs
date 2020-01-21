using PP.Models.Core;
using PP.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PP.Models.Transaction
{
    public class TransactionTugas : CoreJabUni
    {
        public Int64 Id { get; set; }
        public MasterBook Book { get; set; }
        public Nullable<Int64> BookId { get; set; }
        public MasterBab Bab { get; set; }
        public Nullable<Int64> BabId { get; set; }
        public MasterSubBab SubBab { get; set; }
        public Nullable<Int64> SubBabId { get; set; }
        public MasterKelompok MasterKelompok { get; set; }
        public Nullable<Int64> MasterKelompokId { get; set; }

    }
}