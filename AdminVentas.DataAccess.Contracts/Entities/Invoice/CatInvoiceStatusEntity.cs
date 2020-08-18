using System.Collections.Generic;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class CatInvoiceStatusEntity
    {
        public CatInvoiceStatusEntity()
        {
            Invoice = new HashSet<InvoiceEntity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<InvoiceEntity> Invoice { get; set; }
    }
}
