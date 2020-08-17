namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class Product2Tax
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int TaxId { get; set; }

        public Product Product { get; set; }
        public Tax Tax { get; set; }
    }
}
