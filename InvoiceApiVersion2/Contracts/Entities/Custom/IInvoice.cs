using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Entities
{
    public interface IInvoice
    {
        int InvoiceId { get; set; }
        string InvoiceName { get; set; }
        bool IsActive { get; set; }
        IEnumerable<IRule> Rules { get; set; }
    }
}
