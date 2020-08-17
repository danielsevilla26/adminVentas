using System;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ComertialName { get; set; }
        public string Rfc { get; set; }
        public string TaxResidence { get; set; }
        public int Cp { get; set; }
        public string Address { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public DateTime CreateDate { get; set; }

        public CatStatus Status { get; set; }
        public User User { get; set; }
    }
}
