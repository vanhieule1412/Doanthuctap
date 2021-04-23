using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace doanthuctap.Controllers
{
    public class GiaDienController : Controller
    {
        private Models.tinhtiendienEntities4 dc = new Models.tinhtiendienEntities4();
        // GET: GiaDien
        public ActionResult IndexGD()
        {
            return View(dc.GIADIENs.ToList());
        }
        public ActionResult Fromthemgiadien()
        {
            return View();
        }
        public ActionResult themgiadien(Models.GIADIEN gIADIEN)
        {
            if (ModelState.IsValid)
            {
                dc.GIADIENs.Add(gIADIEN);
                dc.SaveChanges();
            }
            return RedirectToAction("IndexGD");
        }
        public ActionResult Fromsuagiadien(int id)
        {
            Models.GIADIEN gIADIEN = dc.GIADIENs.Find(id);
            return View(gIADIEN);
        }
        public ActionResult suagiadien(Models.GIADIEN gIADIEN)
        {
            Models.GIADIEN IADIEN = dc.GIADIENs.Find(gIADIEN.Mabac);
            if (IADIEN!=null)
            {
                IADIEN.Tenbac = gIADIEN.Tenbac;
                IADIEN.Densokw = gIADIEN.Densokw;
                IADIEN.Tusokw = gIADIEN.Tusokw;
                IADIEN.Dongia = gIADIEN.Dongia;
                IADIEN.Ngaythanhlap = gIADIEN.Ngaythanhlap;
                dc.SaveChanges();
            }
            return RedirectToAction("IndexGD");
        }
    }
}