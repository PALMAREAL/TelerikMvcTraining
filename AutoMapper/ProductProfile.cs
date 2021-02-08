using AutoMapper;
using System;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.AutoMapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            MapProduct();
        }

        private void MapProduct()
        {
            CreateMap<ProductViewModel, Product>()
                .ForMember(dest => dest.ProductID, o => o.MapFrom(src => src.ProductIDVm))
                .ForMember(dest => dest.ProductName, o => o.MapFrom(src => src.ProductNameVm))
                .ForMember(dest => dest.SupplierID, o => o.MapFrom(src => src.SupplierIDVm))
                .ForMember(dest => dest.CategoryID, o => o.MapFrom(src => src.CategoryIDVm))
                .ForMember(dest => dest.QuantityPerUnit, o => o.MapFrom(src => src.QuantityPerUnitVm))
                .ForMember(dest => dest.UnitPrice, o => o.MapFrom(src => src.UnitPriceVm))
                .ForMember(dest => dest.UnitsInStock, o => o.MapFrom(src => src.UnitsInStockVm))
                .ForMember(dest => dest.UnitsOnOrder, o => o.MapFrom(src => src.UnitsOnOrderVm))
                .ForMember(dest => dest.ReorderLevel, o => o.MapFrom(src => src.ReorderLevelVm))
                .ForMember(dest => dest.Discontinued, o => o.MapFrom(src => src.DiscontinuedVm)).ReverseMap();
        }
    }
}