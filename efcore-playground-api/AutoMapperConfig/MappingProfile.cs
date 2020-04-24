using AutoMapper;
using efcore_playground.dataaccess.entities;
using efcore_playground.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace efcore_playground_api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Address, AddressDTO>()
                .ForMember(dest => dest.Pin, source => source.MapFrom(z => z.Pin))
                .ForMember(dest => dest.StreetName, source => source.MapFrom(z => z.StreetName));

            CreateMap<AddressDTO, Address>()
                .ForMember(dest => dest.Pin, source => source.MapFrom(z => z.Pin))
                .ForMember(dest => dest.StreetName, source => source.MapFrom(z => z.StreetName));

            CreateMap<Student, StudentDTO>()
                .ForMember(dest => dest.Name, source => source.MapFrom(z => z.Name))
                .ForMember(dest => dest.ID, source => source.MapFrom(z => z.ID))
                .ForMember(dest => dest.Grades, source => source.MapFrom(z => z.Grades))
                .ForMember(dest => dest.Address, source => source.MapFrom(z => z.Address));
            
            CreateMap<StudentDTO, Student>()
                .ForMember(dest => dest.Name, source => source.MapFrom(z => z.Name))
                .ForMember(dest => dest.ID, source => source.MapFrom(z => z.ID))
                .ForMember(dest => dest.Grades, source => source.MapFrom(z => z.Grades))
                .ForMember(dest => dest.Address, source => source.MapFrom(z => z.Address));

            CreateMap<Grade, GradeDTO>()
                .ForMember(dest => dest.Subject, source => source.MapFrom(z => z.Subject))
                .ForMember(dest => dest.Marks, source => source.MapFrom(z => z.Marks));

            CreateMap<GradeDTO, Grade>()
                .ForMember(dest => dest.Subject, source => source.MapFrom(z => z.Subject))
                .ForMember(dest => dest.Marks, source => source.MapFrom(z => z.Marks));
        }
    }
}
