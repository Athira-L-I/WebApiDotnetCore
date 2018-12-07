using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public partial class InvoiceMaster
    {
        public InvoiceMaster()
        {
            RuleDetails = new List<RuleDetails>();
        }
        [Key]
        public int InvoiceId { get; set; }
        public string InvoiceName { get; set; }
        public bool IsActive { get; set; }

        public IEnumerable<RuleDetails> RuleDetails { get; set; }
    }
}
