using System;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public class UserEntity
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string IdStatus { get; set; }

        public DateTime CreateDate { get; set; }
        
        //References
        public virtual CatStatusEntity Status { get; set; }

        public virtual InvoiceEntity Invoice { get; set; }

        public virtual ProductEntity Product { get; set; }

        public virtual TaxEntity Tax { get; set; }

        public virtual CustomerEntity Customer { get; set; }

    }
}
