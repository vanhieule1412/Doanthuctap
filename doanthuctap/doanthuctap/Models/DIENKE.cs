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
    
    public partial class DIENKE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIENKE()
        {
            this.CTHOADONs = new HashSet<CTHOADON>();
        }
    
        public string Madk { get; set; }
        public string Makh { get; set; }
        public System.DateTime Ngaysx { get; set; }
        public System.DateTime Ngaylap { get; set; }
        public string Mota { get; set; }
        public bool Trangthai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOADON> CTHOADONs { get; set; }
        public virtual KHANHHANG KHANHHANG { get; set; }
    }
}
