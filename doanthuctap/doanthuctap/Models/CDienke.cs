using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace doanthuctap.Models
{
    public class CDienke
    {
        [Required(ErrorMessage = "Nhập mã điện kế")]
        [Display(Name = "Mã Điện Kế")]
        public string Madk { get; set; }

        [Required(ErrorMessage = "Nhập tên khách hàng")]
        [Display(Name = "Mã Khách Hàng")]
        public string Makh { get; set; }

        [Required(ErrorMessage = "Nhập Ngày Sản Xuất")]
        [Display(Name = "Ngày Sản Xuất")]
        public System.DateTime Ngaysx { get; set; }

        [Required(ErrorMessage = "Nhập Ngày Lập")]
        [Display(Name = "Ngày Lập")]
        public System.DateTime Ngaylap { get; set; }

        [Required(ErrorMessage = "Nhập Mô Tả")]
        [Display(Name = "Mô Tả")]
        public string Mota { get; set; }

        [Required(ErrorMessage = "Chưa kích hoạt trạng thái")]
        [Display(Name = "Trạng Thái")]
        public bool Trangthai { get; set; }

        
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}