using AutoMapper;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.AutoMapper
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            MapOrder();
        }

        private void MapOrder()
        {
            CreateMap<Order, OrderViewModel>()
                .ForMember(dest => dest.IdOrden, act => act.MapFrom(src => src.OrderID))
                .ForMember(dest => dest.FechaCompra, act => act.MapFrom(src => src.OrderDate))
                .ForMember(dest => dest.ClienteId, act => act.MapFrom(src => src.CustomerID))
                .ForMember(dest => dest.Categoría, act => act.MapFrom(src => src.Category))
                .ForPath(dest => dest.Categoría.CategoryID, act => act.MapFrom(src => src.Category.CategoryID))
                .ForMember(dest => dest.País, act => act.MapFrom(src => src.Country))
                .ReverseMap()
                .ForPath(dest => dest.Category.CategoryName, act => act.MapFrom(src => src.Categoría.CategoryName))
                .ForPath(dest => dest.Category.Description, act => act.MapFrom(src => src.Categoría.Description))
                .ForPath(dest => dest.Category.Picture, act => act.MapFrom(src => src.Categoría.Picture))
                .ForPath(dest => dest.Country.CountryID, act => act.MapFrom(src => src.País.CountryID))
                .ForPath(dest => dest.Country.CountryNameLong, act => act.MapFrom(src => src.País.CountryNameLong))
                .ForPath(dest => dest.Country.CountryNameShort, act => act.MapFrom(src => src.País.CountryNameShort));
        }
    }
}

