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
    
    public partial class KHANHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHANHHANG()
        {
            this.DIENKEs = new HashSet<DIENKE>();
        }
    
        public string Makh { get; set; }
        public string Tenkh { get; set; }
        public string Diachi { get; set; }
        public Nullable<int> Dienthoai { get; set; }
        public string CMND { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIENKE> DIENKEs { get; set; }
    }
}
