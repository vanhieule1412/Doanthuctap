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
            this.CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }
    
        public string Mahd { get; set; }
        public string Ky { get; set; }
        public Nullable<System.DateTime> Tungay { get; set; }
        public Nullable<System.DateTime> Denngay { get; set; }
        public Nullable<int> Chisodau { get; set; }
        public Nullable<int> Chisocuoi { get; set; }
        public Nullable<float> Tongthanhtien { get; set; }
        public Nullable<System.DateTime> Ngaylaphd { get; set; }
        public Nullable<bool> Tinhtrang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
    }
}