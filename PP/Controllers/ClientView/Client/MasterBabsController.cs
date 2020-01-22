using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PP.Models;
using PP.Models.Master;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using PP.ViewModels;

namespace PP.Controllers.ViewClient.Client
{
    //[Authorize(Roles = "Admin")]
    public class MasterBabsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: MasterBabs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ambil_Index()
        {
            var userStore = new UserStore<ApplicationUser>(db);
            var userManager = new UserManager<ApplicationUser>(userStore);
            var userId = User.Identity.GetUserId();
            var user = userManager.FindById(userId);

            var kelompok = user.Kelompok;

            if (kelompok == "PPM" || kelompok == "DGM" || kelompok == "GM")
            {
                var masterBab = db.MasterBab.Include(m => m.Book).ToList();
                return Json(masterBab, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var masterBab = (from kelompoks in db.MasterKelompok.Where(x => x.Nama == kelompok)
                                 join bab in db.MasterBab on kelompoks.Id equals bab.KelompokId into klmpk
                                 from klmpr in klmpk
                                 select new BabBabVM
                                 {
                                     Id = klmpr.Id,
                                     NamaKelompok = kelompoks.Nama,
                                     Nama = klmpr.Nama,
                                     NoInstruksi = klmpr.NoInstruksi,
                                     TanggalBerlaku = klmpr.TanggalBerlaku,
                                     TanggalJatuhTempo = klmpr.TanggalJatuhTempo,
                                     TimeLine = klmpr.TimeLine,
                                     StatusProposal = klmpr.StatusProposal,
                                     Baca = klmpr.Baca
                                 }).ToList();
                return Json(masterBab, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Save(MasterBab masterBab)
        {
            DateTime tanggalJatuhTempo;

            if (masterBab.TanggalBerlaku != null)
            {
                tanggalJatuhTempo = Convert.ToDateTime(masterBab.TanggalBerlaku);
                masterBab.TanggalJatuhTempo = tanggalJatuhTempo.AddYears(1);
            }

            DateTime? akak = masterBab.TanggalJatuhTempo;

            if (masterBab.Id == 0)
            {
                db.MasterBab.Add(masterBab);
                var balik = db.SaveChanges();
                return Json(balik, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var masterbabDB = db.MasterBab.Single(m => m.Id == masterBab.Id);
                masterbabDB.BookId = masterBab.BookId;
                masterbabDB.KelompokId = masterBab.KelompokId;
                masterbabDB.Urutan = masterBab.Urutan;
                masterbabDB.TimeLine = masterBab.TimeLine;
                masterbabDB.NoInstruksi = masterBab.NoInstruksi;
                masterbabDB.StatusProposal = masterBab.StatusProposal;
                masterbabDB.Nama = masterBab.Nama;
                masterbabDB.TanggalBerlaku = masterBab.TanggalBerlaku;
                masterbabDB.TanggalJatuhTempo = masterBab.TanggalJatuhTempo;
                var balik = db.SaveChanges();
                db.Entry(masterbabDB).State = System.Data.Entity.EntityState.Modified;
                return Json(balik, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Delete(long? id)
        {
            MasterBab masterBab = db.MasterBab.Find(id);
            db.MasterBab.Remove(masterBab);
            var response = db.SaveChanges();
            return Json(response, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult UploadBukus(long? id)
        {
            ViewBag.Data = (from bab in db.MasterBab.Where(x => x.Id == id)
                            select bab
                            ).ToList();
            return View();
        }

        [HttpPost]
        public ActionResult UploadBuku(long? Id, HttpPostedFileBase Dokuments)
        {
            if (Dokuments == null)
            {
                ViewBag.Error = "Please Select a Documents File";
                return View("Index");
            }
            else
            {
                string path = Server.MapPath("~/Dataupload/" + Dokuments.FileName);
                Dokuments.SaveAs(path);
                var dokuments = db.MasterBab.Single(m => m.Id == Id);
                dokuments.Id = Convert.ToInt64(Id);
                dokuments.Dokuments = Dokuments.FileName;
                db.Entry(dokuments).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index", "MasterBabs");
        }
        
        public JsonResult Get()
        {
            var result = db.MasterBab.ToList();
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetById(long? id)
        {
            var userStore = new UserStore<ApplicationUser>(db);
            var userManager = new UserManager<ApplicationUser>(userStore);
            var userId = User.Identity.GetUserId();
            var user = userManager.FindById(userId);

            var kelompok = user.Kelompok;
            var result = (from kelompoks in db.MasterKelompok.Where(x => x.Nama == kelompok)
                          join bab in db.MasterBab on kelompoks.Id equals bab.KelompokId into klmpk
                          from klmpr in klmpk
                          select new BabBabVM
                          {
                              Id = klmpr.Id,
                              NamaKelompok = kelompoks.Nama,
                              Nama = klmpr.Nama,
                              NoInstruksi = klmpr.NoInstruksi,
                              TanggalBerlaku = klmpr.TanggalBerlaku,
                              TanggalJatuhTempo = klmpr.TanggalJatuhTempo,
                              TimeLine = klmpr.TimeLine,
                              StatusProposal = klmpr.StatusProposal,
                              Urutan = klmpr.Urutan,
                              Baca = klmpr.Baca
                          }).SingleOrDefault(x => x.Id == id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetByNamaId(long? id)
        {
            var userStore = new UserStore<ApplicationUser>(db);
            var userManager = new UserManager<ApplicationUser>(userStore);
            var userId = User.Identity.GetUserId();
            var user = userManager.FindById(userId);

            var kelompok = user.Kelompok;
            var result = (from bab in db.MasterBab
                          select new BabBabVM
                          {
                              Nama = bab.Nama,
                              Id = bab.Id,
                              StatusProposal = bab.StatusProposal,
                              TanggalBerlaku = bab.TanggalBerlaku,
                              TimeLine = bab.TimeLine,
                              Dokument = bab.Dokuments,
                              Urutan = bab.Urutan,
                              NamaBuku = bab.Book.Nama,
                              NamaKelompok = bab.Kelompok.Nama,
                              NoInstruksi = bab.NoInstruksi,
                          }).SingleOrDefault(x=>x.Id == id && x.NamaKelompok == kelompok);

            var update = db.MasterBab.Single(m => m.Id == id);
            update.Id = Convert.ToInt64(id);
            update.Baca = "1";
            db.Entry(update).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
