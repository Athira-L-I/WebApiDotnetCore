using Contracts.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.DataServices
{
    public interface IParameterDataService
    {
        List<IParameter> GetParameters();
    }
}
