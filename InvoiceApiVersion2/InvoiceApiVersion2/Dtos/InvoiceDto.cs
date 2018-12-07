using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApiVersion2.Dtos
{
    public class InvoiceDto
    {
        public int InvoiceId { get; set; }
        public string InvoiceName { get; set; }
        public bool IsActive { get; set; }

        public IEnumerable<RuleDto> Rules { get; set; }
    }
}
