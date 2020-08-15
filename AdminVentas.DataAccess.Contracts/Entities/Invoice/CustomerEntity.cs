using System;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public class CustomerEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ComertialName { get; set; }

        public string RFC { get; set; }

        public string TaxResidence { get; set; }

        public string CP { get; set; }

        public string Address { get; set; }

        public int IdState { get; set; }

        public int IdCity { get; set; }

        public DateTime CreateDate { get; set; }

        public int IdUser { get; set; }

        public int IdStatus { get; set; }

        //References
        public virtual UserEntity User { get; set; }

        public virtual CatStatusEntity Status { get; set; }
    }
}
