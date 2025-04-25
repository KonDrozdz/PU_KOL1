using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BLL_EF.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            CreateMap<StudentRequestDTO, Student>();
            CreateMap<Student, StudentResponseDTO>()
                .ForMember(dest => dest.NazwaGrupy, opt => opt.MapFrom(src => src.Grupa.Name));

            
            CreateMap<Historia, HistoryResponseDTO>()
                .ForMember(dest => dest.TypAkcji, opt => opt.MapFrom(src => src.TypAkcji))
                .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src.Data));
        }
    }
}
