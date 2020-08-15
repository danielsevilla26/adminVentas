using System;
using System.Collections.Generic;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public class TaxEntity
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public int IdStatus { get; set; }

        public string Name { get; set; }

        //TRASLADO, RETENCION
        public bool TypeAmbit { get; set; }

        //FEDERAL, LOCAL
        public bool Ambit { get; set; }

        public Decimal Rate { get; set; }

        public string TaxKey { get; set; }

        public string FactorType { get; set; }

        public string FeeRate { get; set; }

        public int IdUser { get; set; }

        //References
        public virtual UserEntity User { get; set; }

        public virtual ICollection<Product2TaxEntity> Product2Tax { get; set; }

    }
}
