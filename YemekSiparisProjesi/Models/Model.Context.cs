//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YemekSiparisProjesi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class YemekSiparisEntities : DbContext
    {
        public YemekSiparisEntities()
            : base("name=YemekSiparisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Fatura> Fatura { get; set; }
        public virtual DbSet<GirisTip> GirisTip { get; set; }
        public virtual DbSet<Icecek> Icecek { get; set; }
        public virtual DbSet<Isletme> Isletme { get; set; }
        public virtual DbSet<IsletmeKullanici> IsletmeKullanici { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciTip> KullaniciTip { get; set; }
        public virtual DbSet<Kurye> Kurye { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Siparis> Siparis { get; set; }
        public virtual DbSet<Yiyecek> Yiyecek { get; set; }
        public virtual DbSet<Menu_Gor> Menu_Gor { get; set; }
        public virtual DbSet<User_Roles> User_Roles { get; set; }
    }
}
