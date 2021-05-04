using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace doanthuctap.Models
{
    public class Claphoadon
    {
        public int Mact { get; set; }
        [Required(ErrorMessage = "Nhập mã hóa đơn")]
        [Display(Name = "Mã Hóa Đơn")]
        public string Mahd { get; set; }
        [Required(ErrorMessage = "Nhập điện năng tiêu thụ")]
        [Display(Name = "Điện năng tiêu thụ")]
        public int Dntt { get; set; }

        [Display(Name = "Đơn Giá")]
        public decimal Dongia { get; set; }
        [Required(ErrorMessage = "Nhập ngày lập")]
        [Display(Name = "Ngày Lập")]
        public System.DateTime Ngaythanhlap { get; set; }
       
        [Display(Name = "Chi Tiết Đơn Giá")]
        public string chitietdongia { get; set; }

        [Required(ErrorMessage = "Nhập mã điện kế")]
        [Display(Name = "Mã Điện Kế")]
        public string Madk { get; set; }
    }
}