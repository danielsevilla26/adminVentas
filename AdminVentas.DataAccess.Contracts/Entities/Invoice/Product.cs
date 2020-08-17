﻿using System;
using System.Collections.Generic;

namespace AdminVentas.DataAccess.Contracts.Entities.Invoice
{
    public partial class Product
    {
        public Product()
        {
            Product2Tax = new HashSet<Product2Tax>();
        }

        public int Id { get; set; }
        public string ProdServKey { get; set; }
        public string UnitKey { get; set; }
        public string Idnumber { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public DateTime CreateDate { get; set; }

        public ICollection<Product2Tax> Product2Tax { get; set; }
    }
}
