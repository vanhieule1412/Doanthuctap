﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dienkeEntities2 : DbContext
    {
        public dienkeEntities2()
            : base("name=dienkeEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CTHOADON> CTHOADONs { get; set; }
        public virtual DbSet<DIENKE> DIENKEs { get; set; }
        public virtual DbSet<GIADIEN> GIADIENs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHANHHANG> KHANHHANGs { get; set; }
    }
}
