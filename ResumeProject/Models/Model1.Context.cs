﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResumeProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbResumeeEntities : DbContext
    {
        public DbResumeeEntities()
            : base("name=DbResumeeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_profile> tbl_profile { get; set; }
        public virtual DbSet<tbl_project> tbl_project { get; set; }
        public virtual DbSet<tbl_skill> tbl_skill { get; set; }
        public virtual DbSet<tbl_technology> tbl_technology { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_category> tbl_category { get; set; }
        public virtual DbSet<tbl_contact> tbl_contact { get; set; }
        public virtual DbSet<tbl_service> tbl_service { get; set; }
    
        public virtual ObjectResult<Nullable<int>> ProjeTalebiCount()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("ProjeTalebiCount");
        }
    }
}
