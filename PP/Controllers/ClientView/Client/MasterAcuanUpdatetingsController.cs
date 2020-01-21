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

namespace PP.Controllers.ClientView.Client
{
    public class MasterAcuanUpdatetingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MasterAcuanUpdatetings
        public ActionResult Index()
        {
            return View(db.AcuanUpdateting.ToList());
        }

        // GET: MasterAcuanUpdatetings/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterAcuanUpdateting masterAcuanUpdateting = db.AcuanUpdateting.Find(id);
            if (masterAcuanUpdateting == null)
            {
                return HttpNotFound();
            }
            return View(masterAcuanUpdateting);
        }

        // GET: MasterAcuanUpdatetings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterAcuanUpdatetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nama,Status")] MasterAcuanUpdateting masterAcuanUpdateting)
        {
            masterAcuanUpdateting.Status = "1";
            if (ModelState.IsValid)
            {
                db.AcuanUpdateting.Add(masterAcuanUpdateting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(masterAcuanUpdateting);
        }

        // GET: MasterAcuanUpdatetings/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterAcuanUpdateting masterAcuanUpdateting = db.AcuanUpdateting.Find(id);
            if (masterAcuanUpdateting == null)
            {
                return HttpNotFound();
            }
            return View(masterAcuanUpdateting);
        }

        public JsonResult Get()
        {
            var result = db.AcuanUpdateting.ToList();

            return Json(result, JsonRequestBehavior.AllowGet);

        }

        // POST: MasterAcuanUpdatetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nama,Status")] MasterAcuanUpdateting masterAcuanUpdateting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(masterAcuanUpdateting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(masterAcuanUpdateting);
        }

        // GET: MasterAcuanUpdatetings/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterAcuanUpdateting masterAcuanUpdateting = db.AcuanUpdateting.Find(id);
            if (masterAcuanUpdateting == null)
            {
                return HttpNotFound();
            }
            return View(masterAcuanUpdateting);
        }

        // POST: MasterAcuanUpdatetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            MasterAcuanUpdateting masterAcuanUpdateting = db.AcuanUpdateting.Find(id);
            db.AcuanUpdateting.Remove(masterAcuanUpdateting);
            db.SaveChanges();
            return RedirectToAction("Index");
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
