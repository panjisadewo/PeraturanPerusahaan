using PP.Models;
using PP.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PP.Controllers.ClientView.Client
{
    public class SummaryController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Summary
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InputKebijakan(long? id)
        {
            ViewBag.BabId = id;
            return View();
        }

        [HttpPost]
        public ActionResult InputKebijakan(string HasilReview, string Updating, string DasarUpdating, string AcuanUpdating, string Sebelum, string Sesudah, string DasarPenyusunan, long? BabId)
        {
            var BabIds = db.MasterSummaryBab
                .Where(x=>x.BabId == BabId).ToList();

            if (BabIds.Count().ToString() == "0") {
                MasterSummaryBab masterSummaryBab = new MasterSummaryBab();
                masterSummaryBab.BabId = BabId;
                masterSummaryBab.DasarPenyusunan = DasarPenyusunan;
                masterSummaryBab.DasarUpdating = DasarUpdating;
                masterSummaryBab.AcuanUpdating = AcuanUpdating;
                masterSummaryBab.HasilReview = HasilReview;
                masterSummaryBab.Sebelum = Sebelum;
                masterSummaryBab.Sesudah = Sesudah;
                db.MasterSummaryBab.Add(masterSummaryBab);
                db.SaveChanges();
                return View();
            }else {
                var masterSummaryBab = db.MasterSummaryBab.Single(x => x.BabId == BabId);
                masterSummaryBab.BabId = BabId;
                masterSummaryBab.DasarPenyusunan = DasarPenyusunan;
                masterSummaryBab.DasarUpdating = DasarUpdating;
                masterSummaryBab.AcuanUpdating = AcuanUpdating;
                masterSummaryBab.HasilReview = HasilReview;
                masterSummaryBab.Sebelum = Sebelum;
                masterSummaryBab.Sesudah = Sesudah;
                db.Entry(masterSummaryBab).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return View();
            }
        }

        public ActionResult Strategi()
        {
            return View();
        }
        public ActionResult Prosedur()
        {
            return View();
        }
        public ActionResult InstruksiKerjaSpecifik()
        {
            return View();
        }
    }
}