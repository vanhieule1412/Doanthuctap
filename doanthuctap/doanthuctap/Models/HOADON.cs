//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace doanthuctap.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            this.CTHOADONs = new HashSet<CTHOADON>();
        }
    
        public string Mahd { get; set; }
        public string Ky { get; set; }
        public System.DateTime Tungay { get; set; }
        public System.DateTime Denngay { get; set; }
        public int Chisodau { get; set; }
        public int Chisocuoi { get; set; }
        public decimal Tongthanhtien { get; set; }
        public System.DateTime Ngaylaphd { get; set; }
        public bool Tinhtrang { get; set; }

    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOADON> CTHOADONs { get; set; }
    }
}
