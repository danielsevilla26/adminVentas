using System;
using System.Collections.Generic;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public class ProductEntity
    {
        public int Id { get; set; }

        public string ProdServiceKey { get; set; }

        public int UnitKey { get; set; }

        public string NumberId { get; set; }

        public string Unit { get; set; }

        public string Description { get; set; }

        public Decimal Price { get; set; }

        public int IdUser { get; set; }

        public DateTime CreateDate { get; set; }

        public int IdStatus { get; set; }

        //References
        public virtual UserEntity User { get; set; }

        public virtual CatStatusEntity Status { get; set; }

        public virtual ICollection<Product2TaxEntity> Product2Tax { get; set; }
    }
}
