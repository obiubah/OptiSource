using System;
using AutoMapper;
using OptiSourceProject.Models;

namespace OptiSourceProject.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterModel, User>();
        }
    }
}
