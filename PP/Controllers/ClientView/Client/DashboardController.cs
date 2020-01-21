using PP.Models;
using PP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PP.Controllers.ClientView.Client
{
    public class DashboardController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Dashboard
        public ActionResult Index()
        {
            var babbuku = (from kelompok in db.MasterKelompok
                           select new DashboardKelompokVM
                           {
                               NamaKelompok = kelompok.Nama,
                               book = (from kategori in db.MasterBook
                                       select new DashboardVM
                                       {
                                           NamaBuku = kategori.Nama,
                                           bab = (from bab in db.MasterBab.Where(x => x.BookId == kategori.Id && x.KelompokId == kelompok.Id)
                                                  select new BabVM
                                                  {
                                                      NamaBab = bab.Nama,
                                                      subbab = (from subbab in db.MasterSubBab.Where(x => x.BabId == bab.Id)
                                                                select new SubBabVM
                                                                {
                                                                    NamaSubBab = subbab.Nama,
                                                                    subsubbab = (from subsubbab in db.MasterSubSubBab.Where(x => x.SubBabId == subbab.Id)
                                                                                 select new SubSubBabVM
                                                                                 {
                                                                                     NamaSubSubBab = subsubbab.Nama
                                                                                 }).ToList(),
                                                                    countSubSubBab = db.MasterSubSubBab.Where(x => x.SubBabId == subbab.Id).Count()
                                                                }).ToList()
                                                  }).ToList()
                                       }).ToList()
                           }).ToList();
            return View(babbuku);
        }
    }
}