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
        DbSet<User> User { get; set; }

        DbSet<Customer> Customer { get; set; }

        DbSet<Invoice> Invoice { get; set; }

        DbSet<Product> Product { get; set; }

        DbSet<Tax> Tax { get; set; }

        DbSet<CatStatus> CatStatus { get; set; }

        DbSet<CatInvoiceStatus> CatInvoiceStatus { get; set; }

        DbSet<CatInvoiceType> CatInvoiceType { get; set; }

        DbSet<Product2Tax> Product2Tax { get; set; }

        DbSet<CatAmbitType> CatAmbitType { get; set; }

        DbSet<CatTaxType> CatTaxType { get; set; }

        #region Métodos que permiten realizar el CRUD
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DatabaseFacade Database { get; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

        void RemoveRange(IEnumerable<object> entities);

        EntityEntry Update(object entity);

        #endregion
    }
}
