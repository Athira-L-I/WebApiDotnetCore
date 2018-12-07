using AutoMapper;
using System.Collections.Generic;
using Contracts.BusinessServices;
using InvoiceApiVersion2.Dtos;
using Microsoft.AspNetCore.Mvc;
using Contracts.Entities;

namespace InvoiceApiVersion2.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;
        private readonly IMapper _mapper;

        public InvoiceController(IInvoiceService service, IMapper mapper)
        {
            _invoiceService = service;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<InvoiceDto>), 200)]
        [Route("api/invoices")]
        public IActionResult GetInvoices()
        {
            var invoices = _invoiceService.GetInvoices();
            var result = _mapper.Map<List<IInvoice>, List<InvoiceDto>>(invoices);

            return new ObjectResult(result);
        }

        [HttpGet]
        [ProducesResponseType(typeof(InvoiceDto), 200)]
        [ProducesResponseType(404)]
        [Route("api/invoices/invoice/{id}")]
        public IActionResult GetInvoiceById(int id)
        {
            var invoice = _invoiceService.GetInvoiceById(id);
            if (invoice == null)
            {
                return NotFound();
            }

            var result = _mapper.Map<IInvoice, InvoiceDto>(invoice);
            return new ObjectResult(result);
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(BadRequestObjectResult), 400)]
        [Route("api/invoices/invoice/create-new")]


    }
}