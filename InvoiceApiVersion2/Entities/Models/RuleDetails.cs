using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public partial class RuleDetails
    {
        [Key]
        public int RuleId { get; set; }
        
        public int InvoiceId { get; set; }
        public virtual InvoiceMaster Invoice { get; set; }

        public int ParameterId { get; set; }
        public virtual ParameterMaster Parameter { get; set; }

        public string RuleValue { get; set; }
        public bool IsActive { get; set; }        
        
    }
}
