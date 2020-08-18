using System;
using System.Collections.Generic;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class TaxEntity
    {
        public TaxEntity()
        {
            Product2Tax = new HashSet<Product2TaxEntity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int TypeAmbitId { get; set; }
        public decimal Rate { get; set; }
        public string TaxKey { get; set; }
        public string FactorType { get; set; }
        public string FeeRate { get; set; }
        public int StatusId { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }

        public CatStatusEntity Status { get; set; }
        public CatTaxTypeEntity Type { get; set; }
        public CatAmbitTypeEntity TypeAmbit { get; set; }
        public UserEntity User { get; set; }
        public ICollection<Product2TaxEntity> Product2Tax { get; set; }
    }
}
