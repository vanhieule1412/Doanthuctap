using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace doanthuctap.Models
{
    public class hoadonviewmodel
    {
        public IEnumerable<HOADON> Hoadon { get; set; }
        public IEnumerable<GIADIEN> Giadien { get; set; }
    }
}