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
        public ActionResult IndexKH(string Search, String key)//lấy danh sách khách hàng từ csdl
        {

            if (!string.IsNullOrEmpty(Search))
            {
                if (key == "Ma")
                {
                    return View(dc.KHACHHANGs.Where(x => x.Makh.Contains(Search)));
                }
                else
                {
                    return View(dc.KHACHHANGs.Where(x => x.Tenkh.Contains(Search)));
                }
            }
            else
            {
                return View(dc.KHACHHANGs.ToList());
            }
        }

        public ActionResult Fromthemkhachhang()//hiện thị form thêm khách hàng
        {
            return View();
        }
        [HttpPost]
        public ActionResult themkhachhang(Models.KHACHHANG Khachhang)//hàm xử lý thêm
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                int count = 0;
                count = dc.KHACHHANGs.Count();
                String chuoi = "";
                int chuoi2 = 0;
                if (count > 0)
                {
                    chuoi = Convert.ToString(dc.KHACHHANGs.ToList().ElementAt(count - 1).Makh);

                    chuoi2 = Convert.ToInt32(chuoi.Remove(0, 2)); //loại bỏ kí tự chữ mã hđ
                    if (chuoi2 + 1 < 10)
                    {
                        Khachhang.Makh = "KH00" + (chuoi2 + 1).ToString();

                    }
                    else if (chuoi2 + 1 < 100)
                    {
                        Khachhang.Makh = "KH0" + (chuoi2 + 1).ToString();
                    }
                }
                else
                {
                    Khachhang.Makh = "KH001";
                }
                dc.KHACHHANGs.Add(Khachhang);
                dc.SaveChanges();
                return RedirectToAction("IndexKH");
            }
            return RedirectToAction("themkhachhang");
            //quay trở lại form IndexKH sau khi thêm xong
            //vậy là xong thêm
        }
        public ActionResult Formsuakhachhang(string id)
        {
            Models.KHACHHANG KH = dc.KHACHHANGs.Find(id);
            return View(KH);
        }
        public ActionResult error(string id)
        {
            Models.KHACHHANG kH = dc.KHACHHANGs.Find(id);
            if (kH != null)
            {
                return View(kH);
            }
            return RedirectToAction("IndexKH");
        }
        public ActionResult suakhachhang(Models.KHACHHANG kH)
        {
            Models.KHACHHANG khachhang = dc.KHACHHANGs.Find(kH.Makh);
            if (khachhang != null)
            {
                khachhang.Tenkh = kH.Tenkh;
                khachhang.Dienthoai = kH.Dienthoai;
                khachhang.Diachi = kH.Diachi;
                khachhang.CMND = kH.CMND;
                dc.SaveChanges();
            }
            return RedirectToAction("IndexKH");
        }
        public ActionResult Formxoakhachhang(string id)
        {
            Models.KHACHHANG kH = dc.KHACHHANGs.Find(id);
            if (kH != null)
            {
                return View(kH);
            }
            return RedirectToAction("IndexKH");

        }
        public ActionResult xoakhachhang(string id)
        {
            Models.KHACHHANG kHANHHANG = dc.KHACHHANGs.Find(id);
            if (kHANHHANG != null)
            {
                int ds = dc.DIENKEs.Where(s => s.Makh.Contains(id)).Count();
                var kh = dc.DIENKEs.Where(s => s.Makh.Contains(id)).ToList();

                if (ds==0)
                {
                    dc.KHACHHANGs.Remove(kHANHHANG);
                    dc.SaveChanges();
                    return RedirectToAction("IndexKH");

                }
                else
                {
                    return RedirectToAction("error/"+id);


                }
            }

            return RedirectToAction("IndexKH");

        }

    }
}