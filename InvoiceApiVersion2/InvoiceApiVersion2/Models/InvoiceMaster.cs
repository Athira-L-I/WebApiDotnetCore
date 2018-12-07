using System;
using System.Collections.Generic;

namespace InvoiceApiVersion2.Models
{
    public partial class InvoiceMaster
    {
        public InvoiceMaster()
        {
            RuleDetails = new HashSet<RuleDetails>();
        }

        public int InvoiceId { get; set; }
        public string InvoiceName { get; set; }
        public bool IsActive { get; set; }

        public ICollection<RuleDetails> RuleDetails { get; set; }
    }
}
