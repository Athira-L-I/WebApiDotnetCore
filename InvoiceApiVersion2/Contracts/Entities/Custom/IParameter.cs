using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Entities
{
    public interface IParameter
    {
        int ParameterId { get; set; }
        string ParameterName { get; set; }
    }
}
