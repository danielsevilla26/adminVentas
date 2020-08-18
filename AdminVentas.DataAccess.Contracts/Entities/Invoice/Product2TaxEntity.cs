namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class Product2TaxEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int TaxId { get; set; }

        public ProductEntity Product { get; set; }
        public TaxEntity Tax { get; set; }
    }
}
