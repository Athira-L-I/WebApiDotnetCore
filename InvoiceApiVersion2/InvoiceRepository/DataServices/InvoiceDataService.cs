using Contracts.DataServices;
using Contracts.Entities;
using Entities.Models;
using Entities.Models.Custom;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.DataServices
{
    public class InvoiceDataService : IInvoiceDataService
    {
        private readonly InvoiceDbContext _invoiceDbContext;

        public InvoiceDataService(InvoiceDbContext context)
        {
            _invoiceDbContext = context;
        }

        public List<IInvoice> GetInvoices()
        {
            var invoiceList = _invoiceDbContext.InvoiceMaster
                .Include(i => i.RuleDetails)                
                .Select(j => new Invoice
                {
                    InvoiceId = j.InvoiceId,
                    InvoiceName = j.InvoiceName,
                    Rules = j.RuleDetails.
                        Select(k => new Rule
                            {
                                 RuleId = k.RuleId,
                                 RuleValue = k.RuleValue,
                                 IsActive = k.IsActive,
                                 ParameterId = k.ParameterId,
                                 ParameterName = k.Parameter.ParameterName                           
                            }                    
                        )                  
                }
                );

            return invoiceList.ToList<IInvoice>();
        }

        public IInvoice GetInvoiceById(int id)
        {
            Invoice invoice = _invoiceDbContext.InvoiceMaster
                .Where(i => i.InvoiceId == id)
                .Include(r => r.RuleDetails)
                .Select(j => new Invoice
                {
                    InvoiceId = j.InvoiceId,
                    InvoiceName = j.InvoiceName,
                    Rules = j.RuleDetails.
                        Select(k => new Rule
                        {
                            RuleId = k.RuleId,
                            RuleValue = k.RuleValue,
                            IsActive = k.IsActive,
                            ParameterId = k.ParameterId,
                            ParameterName = k.Parameter.ParameterName
                        }
                        )
                }
                ).FirstOrDefault();

            return invoice;
        }

        public void AddInvoice(IInvoice invoice)
        {
            InvoiceMaster master = new InvoiceMaster
            {
                InvoiceId = invoice.InvoiceId,
                InvoiceName = invoice.InvoiceName,
                IsActive = invoice.IsActive
            };

            _invoiceDbContext.InvoiceMaster.Add(master);

            foreach (var rule in invoice.Rules)
            {
                var rd = new RuleDetails
                {
                    RuleValue = rule.RuleValue,
                    InvoiceId = master.InvoiceId,
                    ParameterId = rule.ParameterId,
                    IsActive = rule.IsActive
                };

                _invoiceDbContext.RuleDetails.Add(rd);
            }

            _invoiceDbContext.SaveChanges();

        }


    }
}
