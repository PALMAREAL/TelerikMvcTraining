using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            // Simple version
            //CreateMap<OrderViewModel, Order >()
            //    .ForMember(dest => dest.OrderID, src => src.MapFrom(o => o.IdOrden))
            //    .ForMember(dest => dest.OrderDate, src => src.MapFrom(o => o.FechaCompra))
            //    .ForMember(dest => dest.CustomerID, src => src.MapFrom(o => o.ClienteId))
            //    .ForMember(dest => dest.Category, src => src.MapFrom(o => o.Categoría))
            //    .ForMember(dest => dest.Country, src => src.MapFrom(o => o.País)).ReverseMap();

            // Complex version
            CreateMap<Order, OrderViewModel>()
                .ForMember(dest => dest.IdOrden, src => src.MapFrom(o => o.OrderID))
                .ForMember(dest => dest.FechaCompra, src => src.MapFrom(o => o.OrderDate))
                .ForMember(dest => dest.ClienteId, src => src.MapFrom(o => o.CustomerID))
                .ForMember(dest => dest.Categoría, src => src.MapFrom(o =>
                            new Category
                            {
                                CategoryID = new CategoryViewModel().CategoryIDVm,
                                CategoryName = new CategoryViewModel().CategoryNameVm,
                                Description = new CategoryViewModel().DescriptionVm,
                                Picture = new CategoryViewModel().PictureVm
                            }))
                .ForMember(dest => dest.País, src => src.MapFrom(o =>
                            new Country
                            {
                                CountryID = new CountryViewModel().CountryID,
                                CountryNameLong = new CountryViewModel().CountryNameLong,
                                CountryNameShort = new CountryViewModel().CountryNameShort
                            })).ReverseMap();
        }
    }
}


//var source = new Order
//{
//    OrderID = 1,
//    OrderDate = new DateTime(2021, 10, 6),
//    CustomerID = 1082,
//    Category = new Category { CategoryID = 1, CategoryName = "Meat", Description = "Soft", Picture = new byte[] { 255, 128 } },
//    Country = new Country { CountryID = 19, CountryNameLong = "Australia", CountryNameShort = "Aus" }
//};