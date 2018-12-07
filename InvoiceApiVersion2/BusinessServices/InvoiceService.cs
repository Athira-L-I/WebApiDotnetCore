using Contracts.BusinessServices;
using Contracts.DataServices;
using Contracts.Entities;
using System.Collections.Generic;

namespace BusinessServices
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceDataService _invoiceData;
        private readonly IParameterDataService _parameterData;

        public InvoiceService(IInvoiceDataService invoice, IParameterDataService parameter)
        {
            _invoiceData = invoice;
            _parameterData = parameter;
        }

        public List<IInvoice> GetInvoices()
        {
            return _invoiceData.GetInvoices();
        }

        public IInvoice GetInvoiceById(int id)
        {
            return _invoiceData.GetInvoiceById(id);
        }

        public void AddInvoice(IInvoice invoice)
        {
            _invoiceData.AddInvoice(invoice);
        }

        public List<IParameter> GetParameters()
        {
            return _parameterData.GetParameters();
        }
    }
}
