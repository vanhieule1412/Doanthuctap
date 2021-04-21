using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace doanthuctap.Controllers
{
    public class HoaDonController : Controller
    {
        private Models.tinhtiendienEntities2 dc = new Models.tinhtiendienEntities2();
        // GET: HoaDon
        public ActionResult IndexHD()
        {

            return View(dc.HOADONs.ToList());
        }
        public ActionResult Formthemhoadon()
        {
            ViewBag.DSgiadien = dc.GIADIENs.ToList();
            return View();
        }
        public ActionResult themhoadon(Models.HOADON hOADON)
        {
            if (ModelState.IsValid)
            {
                dc.HOADONs.Add(hOADON);
                dc.SaveChanges();
            }
            ViewBag.DSgiadien = dc.GIADIENs.ToList();
            return RedirectToAction("IndexHD");
        }
        public ActionResult Formlaphoadon()
        {
            return View();
        }



    }
}