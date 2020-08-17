using System.Collections.Generic;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class CatInvoiceStatus
    {
        public CatInvoiceStatus()
        {
            Invoice = new HashSet<Invoice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Invoice> Invoice { get; set; }
    }
}
