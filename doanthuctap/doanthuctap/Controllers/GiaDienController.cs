using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace doanthuctap.Controllers
{
    public class GiaDienController : Controller
    {
        private Models.tinhtiendienEntities dc = new Models.tinhtiendienEntities();
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
    }
}