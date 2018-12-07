using System;
using System.Collections.Generic;

namespace InvoiceApiVersion2.Models
{
    public partial class RuleDetails
    {
        public int RuleId { get; set; }
        public int InvoiceId { get; set; }
        public int ParameterId { get; set; }
        public string RuleValue { get; set; }
        public bool IsActive { get; set; }

        public InvoiceMaster Invoice { get; set; }
        public ParameterMaster Parameter { get; set; }
    }
}
