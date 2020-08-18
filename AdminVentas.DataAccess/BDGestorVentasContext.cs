using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AdminVentas.DataAccess.Contracts;
using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using AdminVentas.DataAccess.EntityConfig;

namespace AdminVentas.DataAccess
{
    public partial class BDGestorVentasContext : DbContext, IBDGestorVentasContext
    {
        public virtual DbSet<CatAmbitTypeEntity> CatAmbitType { get; set; }
        public virtual DbSet<CatInvoiceStatusEntity> CatInvoiceStatus { get; set; }
        public virtual DbSet<CatInvoiceTypeEntity> CatInvoiceType { get; set; }
        public virtual DbSet<CatStatusEntity> CatStatus { get; set; }
        public virtual DbSet<CatTaxTypeEntity> CatTaxType { get; set; }
        public virtual DbSet<CustomerEntity> Customer { get; set; }
        public virtual DbSet<InvoiceEntity> Invoice { get; set; }
        public virtual DbSet<ProductEntity> Product { get; set; }
        public virtual DbSet<Product2TaxEntity> Product2Tax { get; set; }
        public virtual DbSet<TaxEntity> Tax { get; set; }
        public virtual DbSet<UserEntity> User { get; set; }

        public BDGestorVentasContext()
        {
        }

        /// <summary>
        /// Constructor que instancia el contexto con los options pasados
        /// </summary>
        /// <param name="options"></param>
        public BDGestorVentasContext(DbContextOptions<BDGestorVentasContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=admin-sevilla;Database=BDGestorVentas;Persist Security Info=false;UserEntity ID=adminventas;Password=sevilla260212;");
            }
        }

        /// <summary>
        /// Modelado de clases a configurar
        /// </summary>
        /// <param name="modelBuilder">Entidad a configurar</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserConfig.SetEntityBuilder(modelBuilder.Entity<UserEntity>());
            TaxConfig.SetEntityBuilder(modelBuilder.Entity<TaxEntity>());
            ProductConfig.SetEntityBuilder(modelBuilder.Entity<ProductEntity>());
            Product2TaxConfig.SetEntityBuilder(modelBuilder.Entity<Product2TaxEntity>());
            InvoiceConfig.SetEntityBuilder(modelBuilder.Entity<InvoiceEntity>());
            CustomerConfig.SetEntityBuilder(modelBuilder.Entity<CustomerEntity>());
            CatInvoiceTypeConfig.SetEntityBuilder(modelBuilder.Entity<CatInvoiceTypeEntity>());
            CatInvoiceStatusConfig.SetEntityBuilder(modelBuilder.Entity<CatInvoiceStatusEntity>());
            CatStatusConfig.SetEntityBuilder(modelBuilder.Entity<CatStatusEntity>());
            CatAmbitTypeConfig.SetEntityBuilder(modelBuilder.Entity<CatAmbitTypeEntity>());
            CatTaxTypeConfig.SetEntityBuilder(modelBuilder.Entity<CatTaxTypeEntity>());
        }
    }
}
