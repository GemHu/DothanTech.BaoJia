﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DothanTech.BaoJia.Module
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BaoJiaEntities : DbContext
    {
        public BaoJiaEntities()
            : base("name=BaoJiaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BackChannel> BackChannel { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<DeliveryArea> DeliveryArea { get; set; }
        public DbSet<DeliveryMode> DeliveryMode { get; set; }
        public DbSet<PrintColor> PrintColor { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductModule> ProductModule { get; set; }
        public DbSet<RecommandTable> RecommandTable { get; set; }
        public DbSet<SpecialColor> SpecialColor { get; set; }
        public DbSet<TechnologyRequest> TechnologyRequest { get; set; }
    }
}