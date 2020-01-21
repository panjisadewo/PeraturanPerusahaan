using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PP.Controllers.ClientView.Client
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UploadBuku(long? id, HttpPostedFileBase imgUrl)
        {
            return View();
        }

        public ActionResult UploadBab(long? id, HttpPostedFileBase imgUrl)
        {
            return View();
        }

        public ActionResult UploadSubBab(long? id, HttpPostedFileBase imgUrl)
        {
            return View();
        }

        public ActionResult UploadSubSubBab(long? id, HttpPostedFileBase imgUrl)
        {
            return View();
        }
    }
}