using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanthuctap.Models;

namespace doanthuctap.Controllers
{
    public class HoaDonController : Controller
    {
        private Models.dienkeEntities2 dc = new Models.dienkeEntities2();
        // GET: HoaDon
        public ActionResult IndexHD()
        {
            var table = new hoadonviewmodel
            {
                Giadien = dc.GIADIENs.ToList(),
                Hoadon = dc.HOADONs.ToList()
            };
            return View(table);
        }
        public ActionResult Formthemhoadon()
        {
            //ViewBag.DSgiadien = dc.GIADIENs.ToList();
            return View();
        }
        public ActionResult themhoadon(Models.HOADON hOADON)
        {
            if (ModelState.IsValid)
            {
                dc.HOADONs.Add(hOADON);
                dc.SaveChanges();
            }
           // ViewBag.DSgiadien = dc.GIADIENs.ToList();
            return RedirectToAction("IndexHD");
        }
        public ActionResult Formlaphoadon(string id)
        {
            Models.HOADON hOADON = dc.HOADONs.Find(id);
            ViewBag.mahoadon = hOADON.Mahd;
            ViewBag.dntt = hOADON.Chisocuoi - hOADON.Chisodau;
            ViewBag.tongtien = hOADON.Tongthanhtien;
            ViewBag.dskh = dc.KHANHHANGs.ToList();
            ViewBag.dshd = dc.HOADONs.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult laphoadon(Models.CTHOADON cTHOADON)
        {
            if (ModelState.IsValid)
            {
                dc.CTHOADONs.Add(cTHOADON);
                dc.SaveChanges();
                
                return RedirectToAction("IndexHD");
            }
            ViewBag.dskh = dc.KHANHHANGs.ToList();
            ViewBag.dshd = dc.HOADONs.ToList();
            return View("Formlaphoadon");
            
        }
        




    }
}