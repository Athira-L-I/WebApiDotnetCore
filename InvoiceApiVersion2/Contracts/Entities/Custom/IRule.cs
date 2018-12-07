using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Entities
{
    public interface IRule
    {
        int RuleId { get; set; }
        int ParameterId { get; set; }
        string ParameterName { get; set; }
        string RuleValue { get; set; }
        bool IsActive { get; set; }

    }
}
