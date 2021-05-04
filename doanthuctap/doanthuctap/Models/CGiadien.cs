using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace doanthuctap.Models
{
    public class CGiadien
    {
        [Required(ErrorMessage = "Nhập mã bậc")]
        [Display(Name = "Mã Bậc")]
        public int Mabac { get; set; }
        [Required(ErrorMessage = "Nhập tên bậc")]
        [Display(Name = "Tên Bậc")]
        public string Tenbac { get; set; }
        [Required(ErrorMessage = "Nhập số kw đầu")]
        [Display(Name = "Số kw Đầu")]
        public int Tusokw { get; set; }
        [Required(ErrorMessage = "Nhập số kw cuối")]
        [Display(Name = "Số kw Cuối")]
        public int Densokw { get; set; }
        
        [Display(Name = "Đơn Giá")]
        public decimal Dongia { get; set; }
        [Required(ErrorMessage = "Nhập Ngày thành lập")]
        [Display(Name = "Ngày Thành Lập")]
        public System.DateTime Ngaythanhlap { get; set; }
    }
}