using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BlockVideo.Dtos;
using BlockVideo.Models;

namespace BlockVideo.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}