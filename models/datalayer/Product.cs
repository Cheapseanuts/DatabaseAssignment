using System;
using System.Collections.Generic;

#nullable disable

namespace DBAssignment5.models.datalayer
{
    public partial class Product
    {
        public Product()
        {
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
        }

        public string ProductCode { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int OnHandQuantity { get; set; }

        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
    }
}
