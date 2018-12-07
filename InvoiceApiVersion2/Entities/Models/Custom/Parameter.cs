using Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models.Custom
{
    public class Parameter : IParameter
    {
        public int ParameterId { get; set; }
        public string ParameterName { get; set; }

        public Parameter()
        {

        }
    }
}
