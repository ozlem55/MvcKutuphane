﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcKutuphane.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBKUTUPHANEEntities3 : DbContext
    {
        public DBKUTUPHANEEntities3()
            : base("name=DBKUTUPHANEEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLCEZALAR> TBLCEZALAR { get; set; }
        public virtual DbSet<TBLHAREKET> TBLHAREKET { get; set; }
        public virtual DbSet<TBLKASA> TBLKASA { get; set; }
        public virtual DbSet<TBLKATEGORİ> TBLKATEGORİ { get; set; }
        public virtual DbSet<TBLKITAP> TBLKITAP { get; set; }
        public virtual DbSet<TBLPERSONEL> TBLPERSONEL { get; set; }
        public virtual DbSet<TBLUYELER> TBLUYELER { get; set; }
        public virtual DbSet<TBLYAZAR> TBLYAZAR { get; set; }
        public virtual DbSet<TBLHAKKIMIZDA> TBLHAKKIMIZDA { get; set; }
        public virtual DbSet<TBLILETISIM> TBLILETISIM { get; set; }
        public virtual DbSet<TBLMESAJLAR> TBLMESAJLAR { get; set; }
        public virtual DbSet<TBLDUYURU> TBLDUYURU { get; set; }
        public virtual DbSet<TBLADMIN> TBLADMIN { get; set; }
    
        public virtual ObjectResult<string> EnFazlaKitapYazar()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EnFazlaKitapYazar");
        }
    
        public virtual ObjectResult<Nullable<int>> EnFazlaOkunanKitap()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("EnFazlaOkunanKitap");
        }
    
        public virtual ObjectResult<string> EnAktifÜye()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EnAktifÜye");
        }
    
        public virtual ObjectResult<string> EnBaşarılıPersonel()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EnBaşarılıPersonel");
        }
    
        public virtual ObjectResult<EnAktifÜye1_Result> EnAktifÜye1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EnAktifÜye1_Result>("EnAktifÜye1");
        }
    
        public virtual ObjectResult<EnAktifÜye11_Result> EnAktifÜye11()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EnAktifÜye11_Result>("EnAktifÜye11");
        }
    
        public virtual ObjectResult<EnAktifÜye2_Result> EnAktifÜye2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EnAktifÜye2_Result>("EnAktifÜye2");
        }
    
        public virtual ObjectResult<string> EnFazlaOkunanKitap1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("EnFazlaOkunanKitap1");
        }
    
        public virtual ObjectResult<EnAktifÜye3_Result> EnAktifÜye3()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EnAktifÜye3_Result>("EnAktifÜye3");
        }
    
        public virtual ObjectResult<EnAktifÜye4_Result> EnAktifÜye4()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EnAktifÜye4_Result>("EnAktifÜye4");
        }
    
        public virtual ObjectResult<EnAktifÜye5_Result> EnAktifÜye5()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EnAktifÜye5_Result>("EnAktifÜye5");
        }
    
        public virtual ObjectResult<EnAktifÜye6_Result> EnAktifÜye6()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EnAktifÜye6_Result>("EnAktifÜye6");
        }
    }
}
