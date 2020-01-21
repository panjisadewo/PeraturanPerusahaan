using PP.Models;
using PP.Models.Master;
using PP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.Office.Interop.Word;

namespace PP.Controllers.ClientView.Client
{
    public class ViewDocumentController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ViewDocument
        public ActionResult Index(long? id)
        {
            ViewBag.idj = id;
            return View();
        }

        public ActionResult ClientViewDownloadBuku()
        {
            var babbuku = (from kategori in db.MasterBook
                           select new DashboardVM
                           {
                               Id = kategori.Id,
                               NamaBuku = kategori.Nama,
                               bab = (from bab in db.MasterBab.Where(x => x.BookId == kategori.Id)
                                      select new BabVM
                                      {
                                          Id = bab.Id,
                                          NamaBab = bab.Nama,
                                          subbab = (from subbab in db.MasterSubBab.Where(x => x.BabId == bab.Id)
                                                    select new SubBabVM
                                                    {
                                                        Id = subbab.Id,
                                                        NamaSubBab = subbab.Nama,
                                                        subsubbab = (from subsubbab in db.MasterSubSubBab.Where(x => x.SubBabId == subbab.Id)
                                                                     select new SubSubBabVM
                                                                     {
                                                                         Id = subsubbab.Id,
                                                                         NamaSubSubBab = subsubbab.Nama
                                                                     }).ToList(),
                                                        countSubSubBab = db.MasterSubSubBab.Where(x => x.SubBabId == subbab.Id).Count()
                                                    }).ToList()
                                      }).ToList()
                           }).ToList();
            return View(babbuku);
        }

        public ActionResult Details(long? id)
        {
            var babbuku = (from kategori in db.MasterBook.Where(x => x.Id == id)
                           select new DashboardVM
                           {
                               Id = kategori.Id,
                               NamaBuku = kategori.Nama,
                               bab = (from bab in db.MasterBab.Where(x => x.BookId == kategori.Id)
                                      select new BabVM
                                      {
                                          Id = bab.Id,
                                          Urutan = bab.Urutan,
                                          NamaBab = bab.Nama,
                                          subbab = (from subbab in db.MasterSubBab.Where(x => x.BabId == bab.Id)
                                                    select new SubBabVM
                                                    {
                                                        Id = subbab.Id,
                                                        Urutan = subbab.Urutan,
                                                        NamaSubBab = subbab.Nama,
                                                        subsubbab = (from subsubbab in db.MasterSubSubBab.Where(x => x.SubBabId == subbab.Id)
                                                                     select new SubSubBabVM
                                                                     {
                                                                         Id = subsubbab.Id,
                                                                         Urutan = subsubbab.Urutan,
                                                                         NamaSubSubBab = subsubbab.Nama
                                                                     }).ToList(),
                                                        countSubSubBab = db.MasterSubSubBab.Where(x => x.SubBabId == subbab.Id).Count()
                                                    }).ToList()
                                      }).ToList()
                           }).ToList();
            return View(babbuku);
        }

        public ActionResult previewBab(long? Id)
        {
            MasterBab masterbab = db.MasterBab.Find(Id);
            ViewBag.Url = "http://localhost:34844/Dataupload/"+masterbab.Dokuments;
            return View();
        }

        public ActionResult ClientViewDownloadSubSubBab()
        {
            return View();
        }
    }
}