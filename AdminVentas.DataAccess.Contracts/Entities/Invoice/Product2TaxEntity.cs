namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public class Product2TaxEntity
    {
        public int IdProduct { get; set; }

        public int IdTax { get; set; }

        //References 
        public virtual ProductEntity Product { get; set; }

        public virtual TaxEntity Tax { get; set; }

    }
}
