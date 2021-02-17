using AutoMapper;
using System;
using TelerikMvcTraining.Dtos;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.AutoMapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            MapEmployee();
        }

        private void MapEmployee()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.Salary, act => act.MapFrom(src => src.Salary))
                .ForMember(dest => dest.Department, act => act.MapFrom(src => src.Department))
                .ForMember(dest => dest.Address, act => act.MapFrom(src => src.Address))
                .ReverseMap()
                .ForPath(dest => dest.Address.City, act => act.MapFrom(src => src.Address.Ciudad))
                .ForPath(dest => dest.Address.State, act => act.MapFrom(src => src.Address.Estado))
                .ForPath(dest => dest.Address.Country, act => act.MapFrom(src => src.Address.País))
                .ForPath(dest => dest.Address.Country.CountryID, act => act.MapFrom(src => src.Address.País.CountryID))
                .ForPath(dest => dest.Address.Country.CountryNameShort, act => act.MapFrom(src => src.Address.País.CountryNameShort))
                .ForPath(dest => dest.Address.Country.CountryNameLong, act => act.MapFrom(src => src.Address.País.CountryNameLong));
        }
    }
}