using System;
using System.Collections.Generic;

namespace InvoiceApiVersion2.Models
{
    public partial class ParameterMaster
    {
        public ParameterMaster()
        {
            RuleDetails = new HashSet<RuleDetails>();
        }

        public int ParameterId { get; set; }
        public string ParameterName { get; set; }
        public bool IsActive { get; set; }

        public ICollection<RuleDetails> RuleDetails { get; set; }
    }
}
