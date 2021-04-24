using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanthuctap.Models;

namespace doanthuctap.Controllers
{
    public class laphoadonController : Controller
    {
        private Models.dienkeEntities1 dc = new Models.dienkeEntities1();
        // GET: laphoadon
        public ActionResult IndexHDL()
        {
            var table = new cthoadonviewmodel
            {
                Giadien = dc.GIADIENs.ToList(),
                CTHoadon = dc.CTHOADONs.ToList()
            };
            return View(table);
            
        }
        public ActionResult Formthemhoadonlap()
        {
            ViewBag.dskh = dc.KHANHHANGs.ToList();
            ViewBag.dshd = dc.HOADONs.ToList();
            return View();
        }
        public ActionResult themhoadonlap(Models.CTHOADON cTHOADON)
        {
            if (ModelState.IsValid)
            {
                dc.CTHOADONs.Add(cTHOADON);
                dc.SaveChanges();
                return RedirectToAction("IndexHDL");
            }
            ViewBag.dskh = dc.KHANHHANGs.ToList();
            ViewBag.dshd = dc.HOADONs.ToList();
            return View("Formthemhoadonlap");
            
        }
    }
}