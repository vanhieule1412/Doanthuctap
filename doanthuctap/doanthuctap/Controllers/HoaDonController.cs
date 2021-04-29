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
        private Models.dienkeEntities3 dc = new Models.dienkeEntities3();
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
            ViewBag.dsdk = dc.DIENKEs.ToList();
            ViewBag.dshd = dc.HOADONs.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult laphoadon(Models.CTHOADON cTHOADON)
        {
            
            if (ModelState.IsValid)
            {
                //List<Models.GIADIEN> ds =dc.GIADIENs.ToList();
                
                Models.GIADIEN gd = new Models.GIADIEN();
                    var sodien = cTHOADON.Dntt;
                    if (sodien <= 100)
                    {
                        
                        var a1 = cTHOADON.Dntt * 1242;
                        cTHOADON.chitietdongia = Convert.ToString(cTHOADON.Dntt) + " * " + Convert.ToString(1242) + " = " + Convert.ToString(a1);
                        cTHOADON.chitietdongia += "VAT 10% =" + Convert.ToString((a1) * 10 / 100);
                }
                    else if (sodien <=150 )
                    {
                    var a1 = 100 * 1242;
                    var a2 = (cTHOADON.Dntt-100) * 1304;
                    cTHOADON.chitietdongia = Convert.ToString(100) + " * " + Convert.ToString(1242) + " = " + Convert.ToString(a1) + '\n';
                    
                    cTHOADON.chitietdongia += Convert.ToString(cTHOADON.Dntt - 100) + " * " + Convert.ToString(1304) + " = " + Convert.ToString(a2) + "\n";
                    cTHOADON.chitietdongia += "VAT 10% ="+ Convert.ToString((a1 + a2)*10/100);
                    }
                    else if (sodien <= 200)
                    {
                        var a1 = 100 * 1242;
                        var a2 = 50  * 1304;
                        var a3 = (sodien - 150) * 1651;

                        cTHOADON.chitietdongia = Convert.ToString(100) + " * " + Convert.ToString(1242) + " = " + Convert.ToString(a1) + '\n';
                        cTHOADON.chitietdongia += Convert.ToString(50) + " * " + Convert.ToString(1304) + " = " + Convert.ToString(a2) + "\n";
                        cTHOADON.chitietdongia += Convert.ToString(cTHOADON.Dntt - 150) + " * " + Convert.ToString(1651) + " = " + Convert.ToString(a3) + "\n";
                        cTHOADON.chitietdongia += "VAT 10% =" + Convert.ToString((a1 + a2 +a3) * 10 / 100);
                    }
                    else if (sodien <= 300)
                    {
                        var a1 = 100 * 1242;
                        var a2 = 50 * 1304;
                        var a3 = (50) * 1651;
                    var a4 = (sodien - 200) * 1788;

                        cTHOADON.chitietdongia = Convert.ToString(100) + " * " + Convert.ToString(1242) + " = " + Convert.ToString(a1) + '\n';
                        cTHOADON.chitietdongia += Convert.ToString(50) + " * " + Convert.ToString(1304) + " = " + Convert.ToString(a2) + "\n";
                        cTHOADON.chitietdongia += Convert.ToString(50) + " * " + Convert.ToString(1651) + " = " + Convert.ToString(a3) + "\n";
                        cTHOADON.chitietdongia += Convert.ToString(cTHOADON.Dntt - 200) + " * " + Convert.ToString(1788) + " = " + Convert.ToString(a4) + "\n";

                        cTHOADON.chitietdongia += "VAT 10% =" + Convert.ToString((a1 + a2 + a3 +a4) * 10 / 100);
                    }
                else if (sodien <= 400)
                {
                    var a1 = 100 * 1242;
                    var a2 = 50 * 1304;
                    var a3 = 50 * 1651;
                    var a4 = 100 * 1788;
                    var a5 = (sodien - 300) * 1912;

                        cTHOADON.chitietdongia = Convert.ToString(100) + " * " + Convert.ToString(1242) + " = " + Convert.ToString(a1) + '\n';
                    cTHOADON.chitietdongia += Convert.ToString(50) + " * " + Convert.ToString(1304) + " = " + Convert.ToString(a2) + "\n";
                    cTHOADON.chitietdongia += Convert.ToString(50) + " * " + Convert.ToString(1651) + " = " + Convert.ToString(a3) + "\n";
                    cTHOADON.chitietdongia += Convert.ToString(100) + " * " + Convert.ToString(1788) + " = " + Convert.ToString(a4) + "\n";
                    cTHOADON.chitietdongia += Convert.ToString(cTHOADON.Dntt - 300) + " * " + Convert.ToString(1912) + " = " + Convert.ToString(a5) + "\n";
                    cTHOADON.chitietdongia += "VAT 10% =" + Convert.ToString((a1 + a2 + a3 + a4 +a5) * 10 / 100);
                }

                else if (sodien > 400)
                {
                    var a1 = 100 * 1242;
                    var a2 = 50 * 1304;
                    var a3 = 50 * 1651;
                    var a4 = 100 * 1788;
                    var a5 = 100 * 1912;
                    var a6 = (sodien - 400) * 1962;

                    cTHOADON.chitietdongia = Convert.ToString(100) + " * " + Convert.ToString(1242) + " = " + Convert.ToString(a1) + '\n';
                    cTHOADON.chitietdongia += Convert.ToString(50) + " * " + Convert.ToString(1304) + " = " + Convert.ToString(a2) + "\n";
                    cTHOADON.chitietdongia += Convert.ToString(50) + " * " + Convert.ToString(1651) + " = " + Convert.ToString(a3) + "\n";
                    cTHOADON.chitietdongia += Convert.ToString(100) + " * " + Convert.ToString(1788) + " = " + Convert.ToString(a4) + "\n";
                    cTHOADON.chitietdongia += Convert.ToString(100) + " * " + Convert.ToString(1912) + " = " + Convert.ToString(a5) + "\n";
                    cTHOADON.chitietdongia += Convert.ToString(cTHOADON.Dntt - 400) + " * " + Convert.ToString(1962) + " = " + Convert.ToString(a6) + "\n";
                    cTHOADON.chitietdongia += "VAT 10% =" + Convert.ToString((a1 + a2 + a3 + a4 + a5 +a6) * 10 / 100);
                }

                dc.CTHOADONs.Add(cTHOADON);
                dc.SaveChanges();
                
                return RedirectToAction("IndexHD");
            }
            ViewBag.dsdk = dc.DIENKEs.ToList();
            ViewBag.dshd = dc.HOADONs.ToList();
            return View("Formlaphoadon");
            
        }
        




    }
}