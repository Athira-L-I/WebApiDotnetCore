using AutoMapper;
using Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApiVersion2.Dtos.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<IInvoice, InvoiceDto>().ReverseMap();
            CreateMap<IParameter, ParameterDto>().ReverseMap();
            CreateMap<IRule, RuleDto>().ReverseMap();
        }
    }
}
