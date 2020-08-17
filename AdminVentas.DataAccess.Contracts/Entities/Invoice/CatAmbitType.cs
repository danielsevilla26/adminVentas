using System.Collections.Generic;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class CatAmbitType
    {
        public CatAmbitType()
        {
            Tax = new HashSet<Tax>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Tax> Tax { get; set; }
    }
}
