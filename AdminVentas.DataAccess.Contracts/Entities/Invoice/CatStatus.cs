using System.Collections.Generic;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class CatStatus
    {
        public CatStatus()
        {
            Customer = new HashSet<Customer>();
            Tax = new HashSet<Tax>();
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Customer> Customer { get; set; }
        public ICollection<Tax> Tax { get; set; }
        public ICollection<User> User { get; set; }
    }
}
