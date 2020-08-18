using System;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class InvoiceEntity
    {
        public int Id { get; set; }
        public byte[] Uuid { get; set; }
        public string Rcfreceiver { get; set; }
        public decimal Total { get; set; }
        public string Serie { get; set; }
        public int Folio { get; set; }
        public int UserId { get; set; }
        public int TypeId { get; set; }
        public int StatusId { get; set; }
        public DateTime CreateDate { get; set; }

        public CatInvoiceStatusEntity Status { get; set; }
        public CatInvoiceTypeEntity Type { get; set; }
        public UserEntity User { get; set; }
    }
}
