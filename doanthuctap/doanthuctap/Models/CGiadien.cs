using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace doanthuctap.Models
{
    public class CGiadien
    {
        public int Mabac { get; set; }
        public string Tenbac { get; set; }
        public int Tusokw { get; set; }
        public int Densokw { get; set; }
        public decimal Dongia { get; set; }
        public System.DateTime Ngaythanhlap { get; set; }
    }
}