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
    public class MasterDasarUpdatetingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MasterDasarUpdatetings
        public ActionResult Index()
        {
            return View(db.DasarUpdateting.ToList());
        }

        // GET: MasterDasarUpdatetings/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterDasarUpdateting masterDasarUpdateting = db.DasarUpdateting.Find(id);
            if (masterDasarUpdateting == null)
            {
                return HttpNotFound();
            }
            return View(masterDasarUpdateting);
        }

        // GET: MasterDasarUpdatetings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterDasarUpdatetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nama,Status")] MasterDasarUpdateting masterDasarUpdateting)
        {
            masterDasarUpdateting.Status = "1";
            if (ModelState.IsValid)
            {
                db.DasarUpdateting.Add(masterDasarUpdateting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(masterDasarUpdateting);
        }

        public JsonResult Get()
        {
            var result = db.DasarUpdateting.ToList();

            return Json(result, JsonRequestBehavior.AllowGet);

        }

        // GET: MasterDasarUpdatetings/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterDasarUpdateting masterDasarUpdateting = db.DasarUpdateting.Find(id);
            if (masterDasarUpdateting == null)
            {
                return HttpNotFound();
            }
            return View(masterDasarUpdateting);
        }

        // POST: MasterDasarUpdatetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nama,Status")] MasterDasarUpdateting masterDasarUpdateting)
        {
            if (ModelState.IsValid)
            {
                db.Entry(masterDasarUpdateting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(masterDasarUpdateting);
        }

        // GET: MasterDasarUpdatetings/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterDasarUpdateting masterDasarUpdateting = db.DasarUpdateting.Find(id);
            if (masterDasarUpdateting == null)
            {
                return HttpNotFound();
            }
            return View(masterDasarUpdateting);
        }

        // POST: MasterDasarUpdatetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            MasterDasarUpdateting masterDasarUpdateting = db.DasarUpdateting.Find(id);
            db.DasarUpdateting.Remove(masterDasarUpdateting);
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
