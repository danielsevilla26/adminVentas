using System.Collections.Generic;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class CatTaxTypeEntity
    {
        public CatTaxTypeEntity()
        {
            Tax = new HashSet<TaxEntity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TaxEntity> Tax { get; set; }
    }
}
