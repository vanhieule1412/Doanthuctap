using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace doanthuctap.Models
{
    public class CKhachhang
    {
        [CKhachhangPK(ErrorMessage = "Đã có mã này rồi")]
        [Required(ErrorMessage ="Nhập mã khách hàng")]
        [Display(Name = "Mã Khách Hàng")]
        public string Makh { get; set; }
        [Required(ErrorMessage = "Nhập tên khách hàng")]
        [Display(Name = "Tên Khách Hàng")]
        public string Tenkh { get; set; }
        [Required(ErrorMessage = "Nhập Địa chỉ")]
        [Display(Name = "Địa chỉ")]
        public string Diachi { get; set; }
        [Required(ErrorMessage = "Nhập số điện thoại")]
        [Display(Name = "Điện thoại")]
        public int Dienthoai { get; set; }
        [Required(ErrorMessage = "Nhập CMND")]
        [Display(Name = "CMND")]
        public int CMND { get; set; }

    }
}