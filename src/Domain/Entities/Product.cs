﻿using Arkos.Domain.Common;
using System.Collections.Generic;

namespace Arkos.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public Product()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
            InventoryDetails = new HashSet<InventoryDetail>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }
        public ICollection<InvoiceDetail> InvoiceDetails { get; private set; }
        public ICollection<InventoryDetail> InventoryDetails { get; private set; }
		public ICollection<ProductPrice> ProductPrices { get; set; }
	}
}
