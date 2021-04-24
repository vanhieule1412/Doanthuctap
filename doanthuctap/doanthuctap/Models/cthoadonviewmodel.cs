using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace doanthuctap.Models
{
    public class cthoadonviewmodel
    {
        public IEnumerable<CTHOADON> CTHoadon { get; set; }
        public IEnumerable<GIADIEN> Giadien { get; set; }
    }
}