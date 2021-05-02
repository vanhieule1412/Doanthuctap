using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace doanthuctap.Models
{
    public class CKhachhangPK:ValidationAttribute
    {
        private Models.dienkeEntities3 dc = new dienkeEntities3();
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string Makh = value.ToString();
                Models.KHACHHANG a = dc.KHACHHANGs.Find(Makh);
                if (a == null) return true;
                return false;
            }
            return false;


        }
    }
}