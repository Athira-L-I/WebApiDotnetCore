using Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models.Custom
{
    public class Invoice : IInvoice
    {
        public int InvoiceId { get; set; }
        public string InvoiceName { get; set; }
        public bool IsActive { get; set; }

        public IEnumerable<IRule> Rules { get; set; }

        public Invoice()
        {
            Rules = new List<Rule>();
        }
    }
}
