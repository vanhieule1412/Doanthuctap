using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace doanthuctap.Controllers
{
    public class KhachHangController : Controller
    {
        private Models.dienkeEntities3 dc = new Models.dienkeEntities3();
        // GET: KhachHang
        public ActionResult IndexKH(string Search , String key)//lấy danh sách khách hàng từ csdl
        {
            
            if (!string.IsNullOrEmpty(Search))
            {
                if (key == "Ma")
                {
                    return View(dc.KHANHHANGs.Where(x => x.Makh.Contains(Search)));
                }else
                {
                    return View(dc.KHANHHANGs.Where(x => x.Tenkh.Contains(Search)));
                }
            }
            else
            {
                return View(dc.KHANHHANGs.ToList());
            }
        }

        public ActionResult Fromthemkhachhang()//hiện thị form thêm khách hàng
        {
            return View();
        }
        [HttpPost]
        public ActionResult themkhachhang(Models.KHANHHANG kHANHHANG)//hàm xử lý thêm
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                int count = 0;
                count = dc.KHANHHANGs.Count();
                String chuoi = "";
                int chuoi2 = 0;
                if (count > 0)
                {
                    chuoi = Convert.ToString(dc.KHANHHANGs.ToList().ElementAt(count-1).Makh);

                    chuoi2 = Convert.ToInt32(chuoi.Remove(0, 2)); //loại bỏ kí tự chữ mã hđ
                    if (chuoi2 + 1 < 10)
                    {
                        kHANHHANG.Makh = "KH00" + (chuoi2 + 1).ToString();

                    }
                    else if (chuoi2 + 1 < 100)
                    {
                        kHANHHANG.Makh = "KH0" + (chuoi2 + 1).ToString();
                    }
                }
                else { 
                kHANHHANG.Makh = "KH001";
                    }
                dc.KHANHHANGs.Add(kHANHHANG);
                dc.SaveChanges();
                return RedirectToAction("IndexKH");
            }
            return RedirectToAction("themkhachhang");
            //quay trở lại form IndexKH sau khi thêm xong
            //vậy là xong thêm
        }
        public ActionResult Formsuakhachhang(string id)
        {
            Models.KHANHHANG kHANHHANG = dc.KHANHHANGs.Find(id);
            return View(kHANHHANG);
        }
        public ActionResult suakhachhang(Models.KHANHHANG kHANHHANG)
        {
            Models.KHANHHANG khachhang = dc.KHANHHANGs.Find(kHANHHANG.Makh);
            if (khachhang != null)
            {
                khachhang.Tenkh = kHANHHANG.Tenkh;
                khachhang.Dienthoai = kHANHHANG.Dienthoai;
                khachhang.Diachi = kHANHHANG.Diachi;
                khachhang.CMND = kHANHHANG.CMND;
                dc.SaveChanges();
            }
            return RedirectToAction("IndexKH");
        }
        public ActionResult Formxoakhachhang(string id)
        {
            Models.KHANHHANG kHANHHANG = dc.KHANHHANGs.Find(id);
            if (kHANHHANG != null)
            {
                return View(kHANHHANG);
            }
            return RedirectToAction("IndexKH");

        }
        public ActionResult xoakhachhang(string id)
        {
            Models.KHANHHANG kHANHHANG = dc.KHANHHANGs.Find(id);
            if (kHANHHANG != null)
            {
                dc.KHANHHANGs.Remove(kHANHHANG);
                dc.SaveChanges();
            }

            return RedirectToAction("IndexKH");

        }

    }
}