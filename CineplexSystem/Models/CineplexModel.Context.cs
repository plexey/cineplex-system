﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CineplexSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CPIStudent_dbEntities : DbContext
    {
        public CPIStudent_dbEntities()
            : base("name=CPIStudent_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer30028452> Customer30028452 { get; set; }
        public virtual DbSet<MovieOrders30028452> MovieOrders30028452 { get; set; }
        public virtual DbSet<Orders30028452> Orders30028452 { get; set; }
    }
}