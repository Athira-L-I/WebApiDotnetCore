using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public partial class ParameterMaster
    {
        public ParameterMaster()
        {
            RuleDetails = new HashSet<RuleDetails>();
        }
        [Key]
        public int ParameterId { get; set; }
        public string ParameterName { get; set; }
        public bool IsActive { get; set; }

        public ICollection<RuleDetails> RuleDetails { get; set; }
    }
}
