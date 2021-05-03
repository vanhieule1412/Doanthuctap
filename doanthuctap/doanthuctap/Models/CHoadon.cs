using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace doanthuctap.Models
{
    public class CHoadon
    {
        [Required(ErrorMessage = "Nhập mã hóa đơn")]
        [Display(Name = "Mã Hóa Đơn")]
        public string Mahd { get; set; }

        [Required(ErrorMessage = "Nhập số đợt")]
        [Display(Name = "Kỳ")]
        public string Ky { get; set; }

        [Required(ErrorMessage = "Nhập ngày bắt đầu")]
        [Display(Name = "Từ Ngày")]
        public System.DateTime Tungay { get; set; }

        [Required(ErrorMessage = "Nhập ngày đến")]
        [Display(Name = "Đến Ngày")]
        public System.DateTime Denngay { get; set; }

        [Required(ErrorMessage = "Nhập chỉ số đầu")]
        [Display(Name = "Chỉ Số Đầu")]
        public int Chisodau { get; set; }

        [Required(ErrorMessage = "Nhập chỉ số cuối")]
        [Display(Name = "Chỉ Số Cuối")]
        public int Chisocuoi { get; set; }

        [Display(Name = "Tổng thành tiền")]
        public decimal Tongthanhtien { get; set; }

        [Required(ErrorMessage = "Nhập Ngày lập hóa đơn")]
        [Display(Name = "Ngày Lập Hóa Đơn")]
        public System.DateTime Ngaylaphd { get; set; }
        
        [Display(Name = "Tình trạng")]
        public bool Tinhtrang { get; set; }
    }
}