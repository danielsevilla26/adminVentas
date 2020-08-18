using AdminVentas.DataAccess.Contracts.Entities.Invoice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AdminVentas.DataAccess.Contracts
{
    public interface IBDGestorVentasContext
    {
        DbSet<UserEntity> User { get; set; }

        DbSet<CustomerEntity> Customer { get; set; }

        DbSet<InvoiceEntity> Invoice { get; set; }

        DbSet<ProductEntity> Product { get; set; }

        DbSet<TaxEntity> Tax { get; set; }

        DbSet<CatStatusEntity> CatStatus { get; set; }

        DbSet<CatInvoiceStatusEntity> CatInvoiceStatus { get; set; }

        DbSet<CatInvoiceTypeEntity> CatInvoiceType { get; set; }

        DbSet<Product2TaxEntity> Product2Tax { get; set; }

        DbSet<CatAmbitTypeEntity> CatAmbitType { get; set; }

        DbSet<CatTaxTypeEntity> CatTaxType { get; set; }

        #region Métodos que permiten realizar el CRUD
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DatabaseFacade Database { get; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

        void RemoveRange(IEnumerable<object> entities);

        EntityEntry Update(object entity);

        #endregion
    }
}
