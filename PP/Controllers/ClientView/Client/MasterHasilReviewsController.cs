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
    public class MasterHasilReviewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MasterHasilReviews
        public ActionResult Index()
        {
            return View(db.HasilReview.ToList());
        }

        // GET: MasterHasilReviews/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterHasilReview masterHasilReview = db.HasilReview.Find(id);
            if (masterHasilReview == null)
            {
                return HttpNotFound();
            }
            return View(masterHasilReview);
        }

        // GET: MasterHasilReviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterHasilReviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nama,Status")] MasterHasilReview masterHasilReview)
        {
            masterHasilReview.Status = "1";
            if (ModelState.IsValid)
            {
                db.HasilReview.Add(masterHasilReview);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(masterHasilReview);
        }

        // GET: MasterHasilReviews/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterHasilReview masterHasilReview = db.HasilReview.Find(id);
            if (masterHasilReview == null)
            {
                return HttpNotFound();
            }
            return View(masterHasilReview);
        }

        // POST: MasterHasilReviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nama,Status")] MasterHasilReview masterHasilReview)
        {
            if (ModelState.IsValid)
            {
                db.Entry(masterHasilReview).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(masterHasilReview);
        }

        // GET: MasterHasilReviews/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MasterHasilReview masterHasilReview = db.HasilReview.Find(id);
            if (masterHasilReview == null)
            {
                return HttpNotFound();
            }
            return View(masterHasilReview);
        }

        public JsonResult Get()
        {
            var result = db.HasilReview.ToList();

            return Json(result, JsonRequestBehavior.AllowGet);

        }

        // POST: MasterHasilReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            MasterHasilReview masterHasilReview = db.HasilReview.Find(id);
            db.HasilReview.Remove(masterHasilReview);
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
