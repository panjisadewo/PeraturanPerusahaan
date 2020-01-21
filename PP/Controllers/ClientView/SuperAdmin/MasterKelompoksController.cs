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

namespace PP.Controllers.ViewClient.SuperAdmin
{
    public class MasterKelompoksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MasterKelompoks
        public ActionResult Index()
        {
            return View(db.MasterKelompok.ToList());
        }

        // GET: MasterKelompoks/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterKelompok masterKelompok = db.MasterKelompok.Find(id);
            if (masterKelompok == null)
            {
                return HttpNotFound();
            }
            return View(masterKelompok);
        }

        // GET: MasterKelompoks/Create
        public ActionResult Create()
        {
            return View();
        }

        public JsonResult GetKelompok()
        {
            var result = db.MasterKelompok.ToList();

            return Json(result, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetRoles()
        {
            var result = db.Roles.ToList();

            return Json(result, JsonRequestBehavior.AllowGet);

        }

        // POST: MasterKelompoks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nama")] MasterKelompok masterKelompok)
        {
            if (ModelState.IsValid)
            {
                db.MasterKelompok.Add(masterKelompok);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(masterKelompok);
        }

        // GET: MasterKelompoks/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterKelompok masterKelompok = db.MasterKelompok.Find(id);
            if (masterKelompok == null)
            {
                return HttpNotFound();
            }
            return View(masterKelompok);
        }

        // POST: MasterKelompoks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nama")] MasterKelompok masterKelompok)
        {
            if (ModelState.IsValid)
            {
                db.Entry(masterKelompok).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(masterKelompok);
        }

        // GET: MasterKelompoks/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterKelompok masterKelompok = db.MasterKelompok.Find(id);
            if (masterKelompok == null)
            {
                return HttpNotFound();
            }
            return View(masterKelompok);
        }

        // POST: MasterKelompoks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            MasterKelompok masterKelompok = db.MasterKelompok.Find(id);
            db.MasterKelompok.Remove(masterKelompok);
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
