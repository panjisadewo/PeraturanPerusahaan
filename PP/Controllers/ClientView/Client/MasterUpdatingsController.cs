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
    public class MasterUpdatingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MasterUpdatings
        public ActionResult Index()
        {
            return View(db.Updateting.ToList());
        }

        // GET: MasterUpdatings/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterUpdating masterUpdating = db.Updateting.Find(id);
            if (masterUpdating == null)
            {
                return HttpNotFound();
            }
            return View(masterUpdating);
        }

        // GET: MasterUpdatings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterUpdatings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nama,Status")] MasterUpdating masterUpdating)
        {
            masterUpdating.Status = "1";
            if (ModelState.IsValid)
            {
                db.Updateting.Add(masterUpdating);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(masterUpdating);
        }

        // GET: MasterUpdatings/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterUpdating masterUpdating = db.Updateting.Find(id);
            if (masterUpdating == null)
            {
                return HttpNotFound();
            }
            return View(masterUpdating);
        }

        // POST: MasterUpdatings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nama,Status")] MasterUpdating masterUpdating)
        {
            if (ModelState.IsValid)
            {
                db.Entry(masterUpdating).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(masterUpdating);
        }

        // GET: MasterUpdatings/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterUpdating masterUpdating = db.Updateting.Find(id);
            if (masterUpdating == null)
            {
                return HttpNotFound();
            }
            return View(masterUpdating);
        }

        // POST: MasterUpdatings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            MasterUpdating masterUpdating = db.Updateting.Find(id);
            db.Updateting.Remove(masterUpdating);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult Get()
        {
            var result = db.Updateting.ToList();

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
