using System;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public class InvoiceEntity
    {
        public int Id { get; set; }

        public string UUID { get; set; }

        public string RFCReceiver { get; set; }

        public Decimal Total { get; set; }

        public string Serie { get; set; }

        public int Folio { get; set; }

        public int IdUser { get; set; }

        public int IdType { get; set; }

        public DateTime CreateDate { get; set; }

        public int IdStatus { get; set; }

        //References
        public virtual CatStatusInvoiceEntity Status { get; set; }

        public virtual UserEntity User { get; set; }

        public virtual CatTypeInvoiceEntity Type { get; set; }

    }
}
