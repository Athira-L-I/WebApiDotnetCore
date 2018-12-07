using Entities.Models.Custom;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Contracts.DataServices;
using Contracts.Entities;

namespace Repository.DataServices
{
    public class ParameterDataService : IParameterDataService
    {
        private readonly InvoiceDbContext _invoiceDbContext;

        public ParameterDataService(InvoiceDbContext context)
        {
            _invoiceDbContext = context;
        }

        public List<IParameter> GetParameters()
        {
            var paramList = from parameter in _invoiceDbContext.ParameterMaster
                            where parameter.IsActive == true
                            select new Parameter()
                            {
                                ParameterId = parameter.ParameterId,
                                ParameterName = parameter.ParameterName
                            };

            return paramList.ToList<IParameter>();
        }
    }
}
