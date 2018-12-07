using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Entities;


namespace Contracts.DataServices
{
    public interface IInvoiceDataService
    {
        List<IInvoice> GetInvoices();
        IInvoice GetInvoiceById(int id);
        void AddInvoice(IInvoice invoice);
    }
}
