using System;
using System.Collections.Generic;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class UserEntity
    {
        public UserEntity()
        {
            Customer = new HashSet<CustomerEntity>();
            Invoice = new HashSet<InvoiceEntity>();
            Tax = new HashSet<TaxEntity>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int StatusId { get; set; }
        public DateTime CreateDate { get; set; }

        public CatStatusEntity Status { get; set; }
        public ICollection<CustomerEntity> Customer { get; set; }
        public ICollection<InvoiceEntity> Invoice { get; set; }
        public ICollection<TaxEntity> Tax { get; set; }
    }
}
