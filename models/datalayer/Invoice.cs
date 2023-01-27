using System;
using System.Collections.Generic;

#nullable disable

namespace DBAssignment5.models.datalayer
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
        }

        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal ProductTotal { get; set; }
        public decimal SalesTax { get; set; }
        public decimal Shipping { get; set; }
        public decimal InvoiceTotal { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
    }
}
