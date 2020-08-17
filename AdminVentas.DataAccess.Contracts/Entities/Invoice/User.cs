using System;
using System.Collections.Generic;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class User
    {
        public User()
        {
            Customer = new HashSet<Customer>();
            Invoice = new HashSet<Invoice>();
            Tax = new HashSet<Tax>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int StatusId { get; set; }
        public DateTime CreateDate { get; set; }

        public CatStatus Status { get; set; }
        public ICollection<Customer> Customer { get; set; }
        public ICollection<Invoice> Invoice { get; set; }
        public ICollection<Tax> Tax { get; set; }
    }
}
