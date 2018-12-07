using Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.BusinessServices
{
    public interface IInvoiceService
    {
        List<IInvoice> GetInvoices();
        IInvoice GetInvoiceById(int id);
        void AddInvoice(IInvoice invoice);
        List<IParameter> GetParameters();
    }
}
