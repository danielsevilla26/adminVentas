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
        public virtual DbSet<CatAmbitType> CatAmbitType { get; set; }
        public virtual DbSet<CatInvoiceStatus> CatInvoiceStatus { get; set; }
        public virtual DbSet<CatInvoiceType> CatInvoiceType { get; set; }
        public virtual DbSet<CatStatus> CatStatus { get; set; }
        public virtual DbSet<CatTaxType> CatTaxType { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Product2Tax> Product2Tax { get; set; }
        public virtual DbSet<Tax> Tax { get; set; }
        public virtual DbSet<User> User { get; set; }

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
                optionsBuilder.UseSqlServer("Server=admin-sevilla;Database=BDGestorVentas;Persist Security Info=false;User ID=adminventas;Password=sevilla260212;");
            }
        }

        /// <summary>
        /// Modelado de clases a configurar
        /// </summary>
        /// <param name="modelBuilder">Entidad a configurar</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserConfig.SetEntityBuilder(modelBuilder.Entity<User>());
            TaxConfig.SetEntityBuilder(modelBuilder.Entity<Tax>());
            ProductConfig.SetEntityBuilder(modelBuilder.Entity<Product>());
            Product2TaxConfig.SetEntityBuilder(modelBuilder.Entity<Product2Tax>());
            InvoiceConfig.SetEntityBuilder(modelBuilder.Entity<Invoice>());
            CustomerConfig.SetEntityBuilder(modelBuilder.Entity<Customer>());
            CatInvoiceTypeConfig.SetEntityBuilder(modelBuilder.Entity<CatInvoiceType>());
            CatInvoiceStatusConfig.SetEntityBuilder(modelBuilder.Entity<CatInvoiceStatus>());
            CatStatusConfig.SetEntityBuilder(modelBuilder.Entity<CatStatus>());
            CatAmbitTypeConfig.SetEntityBuilder(modelBuilder.Entity<CatAmbitType>());
            CatTaxTypeConfig.SetEntityBuilder(modelBuilder.Entity<CatTaxType>());
        }
    }
}
