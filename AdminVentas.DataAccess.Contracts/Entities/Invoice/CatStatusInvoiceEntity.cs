namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public class CatStatusInvoiceEntity
    {
        public int Id { get; set; }
        //Vigente,Cancelada
        public string Name { get; set; }

        //References
        public virtual InvoiceEntity Invoice { get; set; }
    }
}
