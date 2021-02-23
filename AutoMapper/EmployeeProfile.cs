using AutoMapper;
using System;
using TelerikMvcTraining.Dtos;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.AutoMapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            MapEmployeeToDto();

            MapEmployeeToViewModel();
        }

        private void MapEmployeeToDto()
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

        private void MapEmployeeToViewModel()
        {
            CreateMap<Employee, EmployeeViewModel>()
                .ForMember(dest => dest.Nombre, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.Salario, act => act.MapFrom(src => src.Salary))
                .ForMember(dest => dest.Departmento, act => act.MapFrom(src => src.Department))
                .ForMember(dest => dest.Dirección, act => act.MapFrom(src => src.Address))
                .ForMember(dest => dest.Pedidos, act => act.MapFrom(src => src.Orders))
                .ReverseMap();


        }
    }
}