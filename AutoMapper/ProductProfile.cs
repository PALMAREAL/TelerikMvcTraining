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
                .ForMember(dest => dest.ProductID, src => src.MapFrom(o => o.ProductIDVm))
                .ForMember(dest => dest.ProductName, src => src.MapFrom(o => o.ProductNameVm))
                .ForMember(dest => dest.SupplierID, src => src.MapFrom(o => o.SupplierIDVm))
                .ForMember(dest => dest.CategoryID, src => src.MapFrom(o => o.CategoryIDVm))
                .ForMember(dest => dest.QuantityPerUnit, src => src.MapFrom(o => o.QuantityPerUnitVm))
                .ForMember(dest => dest.UnitPrice, src => src.MapFrom(o => o.UnitPriceVm))
                .ForMember(dest => dest.UnitsInStock, src => src.MapFrom(o => o.UnitsInStockVm))
                .ForMember(dest => dest.UnitsOnOrder, src => src.MapFrom(o => o.UnitsOnOrderVm))
                .ForMember(dest => dest.ReorderLevel, src => src.MapFrom(o => o.ReorderLevelVm))
                .ForMember(dest => dest.Discontinued, src => src.MapFrom(o => o.DiscontinuedVm)).ReverseMap();
        }
    }
}