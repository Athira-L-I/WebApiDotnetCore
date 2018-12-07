using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApiVersion2.Dtos
{
    public class RuleDto
    {
        public int RuleId { get; set; }

        public int ParameterId { get; set; }
        public string ParameterName { get; set; }

        public string RuleValue { get; set; }
        public bool IsActive { get; set; }
    }
}
