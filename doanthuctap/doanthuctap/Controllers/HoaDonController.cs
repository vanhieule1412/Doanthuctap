using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using doanthuctap.Models;
using System.Globalization;

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
                var sodien = hOADON.Chisocuoi - hOADON.Chisodau;
                List<GIADIEN> ds =dc.GIADIENs.ToList();
                foreach (var a in ds)
                {

                    if (sodien > 0 && sodien <= 100 && a.Mabac == 1)
                    {
                        hOADON.Tongthanhtien = sodien * a.Dongia;
                        //cout<< 'a + b' = a+b
                        //print(sodien * a.Dongia)
                        //80*1020 = Tongthanhtien
                        //Html.DisplayFor(sodien * a.Dongia)
                        break;
                    }
                    else if (sodien > 101 && sodien <= 150)//101 - 150
                    {
                        if (a.Mabac == 1)
                        {
                            hOADON.Tongthanhtien += 100 * a.Dongia;
                            //
                        }


                        else if (sodien - 100 > 0 && a.Mabac == 2)
                        {

                            sodien = sodien - 100;//23
                            hOADON.Tongthanhtien += sodien * a.Dongia;
                            break;
                        }
                    }
                    else if (sodien > 151 && sodien <= 200)//151 -200
                    {
                        //170
                        if (a.Mabac == 1)
                        {
                            hOADON.Tongthanhtien += 100 * a.Dongia;
                        }


                        else if (sodien - 100 > 0 && a.Mabac == 2)//70
                        {
                            //170
                            sodien = sodien - 100;//70
                            hOADON.Tongthanhtien += 50 * a.Dongia;//?
                            sodien = sodien + 100;//170

                        }

                        else if (sodien - 50 > 0 && a.Mabac == 3)
                        {

                            sodien = sodien - 150;//20
                            hOADON.Tongthanhtien += sodien * a.Dongia;
                            break;
                        }


                    }
                    else if (sodien >= 201 && sodien <= 300)//151 -200
                    {
                        //230
                        if (a.Mabac == 1)
                        {
                            hOADON.Tongthanhtien += 100 * a.Dongia;
                        }


                        else if (sodien - 100 > 0 && a.Mabac == 2)//70
                        {
                            //230
                            sodien = sodien - 100;//130
                            hOADON.Tongthanhtien += 50 * a.Dongia;//?
                            sodien = sodien + 100;//230

                        }

                        else if (sodien - 50 > 0 && a.Mabac == 3)
                        {

                            sodien = sodien - 150;//80
                            hOADON.Tongthanhtien += 50 * a.Dongia;
                            sodien = sodien + 150;

                        }
                        else if (sodien - 50 > 0 && a.Mabac == 4)
                        {

                            sodien = sodien - 200;//30
                            hOADON.Tongthanhtien += sodien * a.Dongia;
                            break;
                        }


                    }
                    else if (sodien > 301 && sodien <= 400)
                    {
                        //230
                        if (a.Mabac == 1)
                        {
                            hOADON.Tongthanhtien += 100 * a.Dongia;//?
                        }


                        else if (a.Mabac == 2)//70
                        {
                            //350
                            sodien = sodien - 100;//250
                            hOADON.Tongthanhtien += 50 * a.Dongia;//?
                            sodien = sodien + 100;//350

                        }

                        else if (a.Mabac == 3)
                        {

                            sodien = sodien - 150;//100
                            hOADON.Tongthanhtien += 50 * a.Dongia;
                            sodien = sodien + 150;//350

                        }
                        else if (a.Mabac == 4)
                        {

                            sodien = sodien - 200;//150
                            hOADON.Tongthanhtien += 100 * a.Dongia;
                            sodien = sodien + 200;//350
                        }
                        else if (a.Mabac == 5)
                        {

                            sodien = sodien - 300;//50
                            hOADON.Tongthanhtien += sodien * a.Dongia;
                            break;
                        }


                    }
                    //>401
                    else if (sodien > 401)
                    {

                        if (a.Mabac == 1)
                        {
                            hOADON.Tongthanhtien += 100 * a.Dongia;//?
                        }


                        else if (sodien - 100 > 0 && a.Mabac == 2)//400
                        {
                            //350
                            sodien = sodien - 100;//250
                            hOADON.Tongthanhtien += 50 * a.Dongia;//?
                            sodien = sodien + 100;//350

                        }

                        else if (sodien - 50 > 0 && a.Mabac == 3)//350
                        {

                            sodien = sodien - 150;//100
                            hOADON.Tongthanhtien += 50 * a.Dongia;
                            sodien = sodien + 150;//350

                        }
                        else if (sodien - 50 > 0 && a.Mabac == 4)//300
                        {

                            sodien = sodien - 200;//150
                            hOADON.Tongthanhtien += 100 * a.Dongia;
                            sodien = sodien + 200;//350
                        }
                        else if (sodien - 100 > 0 && a.Mabac == 5)//200
                        {

                            sodien = sodien - 300;//50
                            hOADON.Tongthanhtien += 100 * a.Dongia;
                            sodien = sodien + 300;//50

                        }
                        else if (sodien - 100 > 0 && a.Mabac == 6)//100
                        {

                            sodien = sodien - 400;//50
                            hOADON.Tongthanhtien += sodien * a.Dongia ;
                            break;
                        }


                    }

                }
                hOADON.Tongthanhtien += hOADON.Tongthanhtien * 10 / 100;
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
                decimal a1 = 0;
                decimal a2 = 0;
                decimal a3 = 0;
                decimal a4 = 0;
                decimal a5 = 0;
                decimal a6 = 0;

                List<Models.GIADIEN> ds = dc.GIADIENs.ToList();
                foreach (var item in ds)
                {
                    var sodien = cTHOADON.Dntt;

                    if (sodien <= 100 && item.Mabac == 1)
                    {
                        a1 = cTHOADON.Dntt * item.Dongia;
                        cTHOADON.chitietdongia = Convert.ToString(cTHOADON.Dntt) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a1);
                    }
                    else if (sodien > 101 && sodien <= 150)//101 - 150
                    {
                        if (item.Mabac == 1)
                        {
                            a1 = 100 * item.Dongia;
                            cTHOADON.chitietdongia = Convert.ToString(100) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a1) + '\n';
                        }


                        else if (sodien - 100 > 0 && item.Mabac == 2)
                        {
                            a2 = (cTHOADON.Dntt - 100) * item.Dongia;

                            cTHOADON.chitietdongia += Convert.ToString(cTHOADON.Dntt - 100) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a2) + "\n";
                            cTHOADON.chitietdongia += "VAT 10% =" + Convert.ToString((a1 + a2) * 10 / 100);
                        }
                    }
                    else if (sodien >= 151 && sodien <= 200)//151 -200
                    {
                        //170
                        if (item.Mabac == 1)
                        {
                            a1 = 100 * item.Dongia;
                            cTHOADON.chitietdongia = Convert.ToString(100) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a1) + '\n';
                        }


                        else if (sodien - 100 > 0 && item.Mabac == 2)//70
                        {
                            //170
                            a2 = 50 * item.Dongia;
                            cTHOADON.chitietdongia += Convert.ToString(cTHOADON.Dntt - 100) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a2) + "\n";

                        }
                        else if (sodien - 50 > 0 && item.Mabac == 3)
                        {
                            a3 = (sodien - 150) * item.Dongia;
                            //cTHOADON.chitietdongia = Convert.ToString(100) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a1) + '\n';
                            //cTHOADON.chitietdongia += Convert.ToString(50) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a2) + "\n";
                            cTHOADON.chitietdongia += Convert.ToString(cTHOADON.Dntt - 150) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a3) + "\n";
                            cTHOADON.chitietdongia += "VAT 10% =" + Convert.ToString((a1 + a2 + a3) * 10 / 100);
                        }
                    }
                    else if (sodien >= 201 && sodien <= 300)//151 -200
                    {
                        //230
                        if (item.Mabac == 1)
                        {
                            a1 = 100 * item.Dongia;
                            cTHOADON.chitietdongia = Convert.ToString(100) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a1) + '\n';
                        }


                        else if (sodien - 100 > 0 && item.Mabac == 2)//70
                        {
                            //230
                            a2 = 50 * item.Dongia;
                            cTHOADON.chitietdongia += Convert.ToString(cTHOADON.Dntt - 100) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a2) + "\n";

                        }

                        else if (sodien - 50 > 0 && item.Mabac == 3)
                        {

                            a3 = 50 * item.Dongia;

                            cTHOADON.chitietdongia += Convert.ToString(cTHOADON.Dntt - 150) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a3) + "\n";

                        }
                        else if (sodien - 50 > 0 && item.Mabac == 4)
                        {

                            a4 = (sodien - 200) * item.Dongia;
                            cTHOADON.chitietdongia += Convert.ToString(cTHOADON.Dntt - 200) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a4) + "\n";

                            cTHOADON.chitietdongia += "VAT 10% =" + Convert.ToString((a1 + a2 + a3 + a4) * 10 / 100);
                        }
                    }
                    else if (sodien >= 301 && sodien <= 400)
                    {
                        //230
                        if (item.Mabac == 1)
                        {

                            a1 = 100 * item.Dongia;
                            cTHOADON.chitietdongia = Convert.ToString(100) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a1) + '\n';
                        }
                        else if (sodien - 100 > 0 && item.Mabac == 2)//70
                        {
                            //dn =400 -59 =350
                            a2 = 50 * item.Dongia;
                            cTHOADON.chitietdongia += Convert.ToString(50) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a2) + "\n";

                        }
                        else if (sodien - 50 > 0 && item.Mabac == 3)
                        {

                            a3 = 50 * item.Dongia;
                            cTHOADON.chitietdongia += Convert.ToString(50) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a3) + "\n";
                        }
                        else if (sodien - 50 > 0 && item.Mabac == 4)
                        {

                            a4 = 100 * item.Dongia;
                            cTHOADON.chitietdongia += Convert.ToString(100) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a4) + "\n";
                        }
                        else if (sodien - 100 > 0 && item.Mabac == 5)
                        {
                            a5 = (sodien - 300) * item.Dongia;
                            cTHOADON.chitietdongia += Convert.ToString(cTHOADON.Dntt - 300) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a5) + "\n";
                            cTHOADON.chitietdongia += "VAT 10% =" + Convert.ToString((a1 + a2 + a3 + a4 + a5) * 10 / 100);
                        }
                    }
                    else if (sodien > 400)
                    {
                        //230
                        if (item.Mabac == 1)
                        {

                            a1 = 100 * item.Dongia;
                            cTHOADON.chitietdongia = Convert.ToString(100) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a1) + '\n';
                        }
                        else if (sodien - 100 > 0 && item.Mabac == 2)//70
                        {
                            //dn =400 -59 =350
                            a2 = 50 * item.Dongia;
                            cTHOADON.chitietdongia += Convert.ToString(50) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a2) + "\n";

                        }
                        else if (sodien - 50 > 0 && item.Mabac == 3)
                        {

                            a3 = 50 * item.Dongia;
                            cTHOADON.chitietdongia += Convert.ToString(50) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a3) + "\n";
                        }
                        else if (sodien - 50 > 0 && item.Mabac == 4)
                        {

                            a4 = 100 * item.Dongia;
                            cTHOADON.chitietdongia += Convert.ToString(100) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a4) + "\n";
                        }
                        else if (sodien - 100 > 0 && item.Mabac == 5)
                        {
                            a5 = 100 * item.Dongia;
                            cTHOADON.chitietdongia += Convert.ToString(100) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a5) + "\n";

                        }
                        else if ( item.Mabac == 6)
                        {
                            a6= (sodien - 400) * item.Dongia;
                            cTHOADON.chitietdongia += Convert.ToString(cTHOADON.Dntt - 400) + " * " + Convert.ToString(item.Dongia) + " = " + Convert.ToString(a6) + "\n";
                            cTHOADON.chitietdongia += "VAT 10% =" + Convert.ToString((a1 + a2 + a3 + a4 + a5+a6) * 10 / 100);
                        }
                    }
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