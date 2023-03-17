using AutoMapper;
using Core.DTOs;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MapperProfiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Make, MakeDto>().ReverseMap();

            CreateMap<Year, YearDto>().ReverseMap();

            CreateMap<Engine, EngineDto>().ReverseMap();

            CreateMap<Model, ModelDto>().ReverseMap();

            CreateMap<Car, CarDto>()
                .ForMember(c => c.Make, opt => opt.MapFrom(c => c.Make))
                .ForMember(c => c.Model, opt => opt.MapFrom(c => c.Model))
                .ForMember(c => c.Engine, opt => opt.MapFrom(c => c.Engine));
            CreateMap<CarDto, Car>();
        }
    }
}
