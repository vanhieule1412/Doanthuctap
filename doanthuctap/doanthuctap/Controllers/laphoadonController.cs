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
        private Models.dienkeEntities3 dc = new Models.dienkeEntities3();
        // GET: laphoadon
        public ActionResult IndexHDL()
        {
            var table = new cthoadonviewmodel
            {
                Giadien = dc.GIADIENs.ToList(),
                CTHoadon = dc.CTHOADONs.ToList(),
                HoaDon =dc.HOADONs.ToList()
            };
            return View(table);
            
        }
        public ActionResult Formxoalaphoadon(int id)
        {
          
            //List<HOADON> ds = dc.HOADONs.ToList();
            //bool coXoa = true;
            Models.CTHOADON cTHOADON = dc.CTHOADONs.Find(id);
            //foreach (var item in ds)
            //{
            //    if (item.Tinhtrang == false)
            //    {
            //        coXoa = false;
            //        break;
            //    }
            //}
            //ViewBag.Xoakh = coXoa;
            if (cTHOADON != null)
            {
                return View(cTHOADON);
            }
            return RedirectToAction("IndexHDL");

        }
        public ActionResult xoalaphoadon(int id)
        {

            Models.CTHOADON cTHOADON = dc.CTHOADONs.Find(id);
            if (cTHOADON != null)
            {
                dc.CTHOADONs.Remove(cTHOADON);
                dc.SaveChanges();
            }

            return RedirectToAction("IndexHDL");

        }

    }
}