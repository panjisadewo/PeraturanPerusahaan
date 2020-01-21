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
using PP.ViewModels;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace PP.Controllers.ViewClient.Client
{
    public class MasterBooksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MasterBooks
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
                var masterbook = db.MasterBook.ToList();
                return Json(masterbook, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var masterbook = db.MasterBook.ToList();
                return Json(masterbook, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult GetById(long? id)
        {
            var userStore = new UserStore<ApplicationUser>(db);
            var userManager = new UserManager<ApplicationUser>(userStore);
            var userId = User.Identity.GetUserId();
            var user = userManager.FindById(userId);

            var kelompok = user.Kelompok;
            var result = db.MasterBook.SingleOrDefault(x => x.Id == id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Save(MasterBook masterbook)
        {
            DateTime tanggalJatuhTempo;

            if (masterbook.TanggalBerlaku != null)
            {
                tanggalJatuhTempo = Convert.ToDateTime(masterbook.TanggalBerlaku);
                masterbook.TanggalJatuhTempo = tanggalJatuhTempo.AddYears(1);
            }

            DateTime? akak = masterbook.TanggalJatuhTempo;

            if (masterbook.Id == 0)
            {
                db.MasterBook.Add(masterbook);
                var balik = db.SaveChanges();
                return Json(balik, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var masterbabDB = db.MasterBook.Single(m => m.Id == masterbook.Id);
                masterbabDB.Urutan = masterbook.Urutan;
                masterbabDB.TimeLine = masterbook.TimeLine;
                masterbabDB.NoInstruksi = masterbook.NoInstruksi;
                masterbabDB.StatusProposal = masterbook.StatusProposal;
                masterbabDB.Nama = masterbook.Nama;
                masterbabDB.TanggalBerlaku = masterbook.TanggalBerlaku;
                masterbabDB.TanggalJatuhTempo = masterbook.TanggalJatuhTempo;
                var balik = db.SaveChanges();
                db.Entry(masterbabDB).State = System.Data.Entity.EntityState.Modified;
                return Json(balik, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Delete(long? id)
        {
            MasterBook masterbook = db.MasterBook.Find(id);
            db.MasterBook.Remove(masterbook);
            var response = db.SaveChanges();
            return Json(response, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult UploadBukus(long? id)
        {
            ViewBag.Data = (from book in db.MasterBook.Where(x => x.Id == id)
                            select book
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
            else {
                    string path = Server.MapPath("~/Dataupload/" + Dokuments.FileName);
                    Dokuments.SaveAs(path);
                    var dokuments = db.MasterBook.Single(m=>m.Id == Id);
                    dokuments.Id = Convert.ToInt64(Id);
                    dokuments.Dokuments = Dokuments.FileName;
                    db.Entry(dokuments).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
            }
            return RedirectToAction("Index", "MasterBooks");
        }
        
        public JsonResult Get()
        {
            var result = db.MasterBook.ToList();

            return Json(result, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetByNamaId(long? id)
        {
            var userStore = new UserStore<ApplicationUser>(db);
            var userManager = new UserManager<ApplicationUser>(userStore);
            var userId = User.Identity.GetUserId();
            var user = userManager.FindById(userId);

            var kelompok = user.Kelompok;
            var result = (from bab in db.MasterBook
                          select new MasterBooksVM
                          {
                              Nama = bab.Nama,
                              Id = bab.Id,
                              StatusProposal = bab.StatusProposal,
                              TanggalBerlaku = bab.TanggalBerlaku,
                              TimeLine = bab.TimeLine,
                              Dokument = bab.Dokuments,
                              Urutan = bab.Urutan,
                              NoInstruksi = bab.NoInstruksi,
                          }).SingleOrDefault(x => x.Id == id);
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
