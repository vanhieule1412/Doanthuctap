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
                
                Models.KHACHHANG kHACHHANG = dc.KHACHHANGs.Find(value);
                if (kHACHHANG == null) return true;
                return false;
           
            
        }
    }
}