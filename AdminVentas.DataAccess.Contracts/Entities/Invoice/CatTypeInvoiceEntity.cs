namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public class CatTypeInvoiceEntity
    {
        public int Id { get; set; }
        //Factura, Pago
        public string Name { get; set; }

        //References
        public virtual InvoiceEntity Invoice { get; set; }
    }
}
