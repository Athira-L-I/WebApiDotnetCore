using Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models.Custom
{
    public class Rule : IRule
    {
        public int RuleId { get; set; }         

        public int ParameterId { get; set; }
        public string ParameterName { get; set; }
        
        public string RuleValue { get; set; }
        public bool IsActive { get; set; }
    }
}
