using System;
using System.Collections.Generic;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class Tax
    {
        public Tax()
        {
            Product2Tax = new HashSet<Product2Tax>();
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

        public CatStatus Status { get; set; }
        public CatTaxType Type { get; set; }
        public CatAmbitType TypeAmbit { get; set; }
        public User User { get; set; }
        public ICollection<Product2Tax> Product2Tax { get; set; }
    }
}
