using System.Collections.Generic;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class CatStatusEntity
    {
        public CatStatusEntity()
        {
            Customer = new HashSet<CustomerEntity>();
            Tax = new HashSet<TaxEntity>();
            User = new HashSet<UserEntity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CustomerEntity> Customer { get; set; }
        public ICollection<TaxEntity> Tax { get; set; }
        public ICollection<UserEntity> User { get; set; }
    }
}
