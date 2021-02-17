using AutoMapper;
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
                .ForMember(dest => dest.ProductID, act => act.MapFrom(src => src.ProductIDVm))
                .ForMember(dest => dest.ProductName, act => act.MapFrom(src => src.ProductNameVm))
                .ForMember(dest => dest.SupplierID, act => act.MapFrom(src => src.SupplierIDVm))
                .ForMember(dest => dest.CategoryID, act => act.MapFrom(src => src.CategoryIDVm))
                .ForMember(dest => dest.QuantityPerUnit, act => act.MapFrom(src => src.QuantityPerUnitVm))
                .ForMember(dest => dest.UnitPrice, act => act.MapFrom(src => src.UnitPriceVm))
                .ForMember(dest => dest.UnitsInStock, act => act.MapFrom(src => src.UnitsInStockVm))
                .ForMember(dest => dest.UnitsOnOrder, act => act.MapFrom(src => src.UnitsOnOrderVm))
                .ForMember(dest => dest.ReorderLevel, act => act.MapFrom(src => src.ReorderLevelVm))
                .ForMember(dest => dest.Discontinued, act => act.MapFrom(src => src.DiscontinuedVm)).ReverseMap();
        }
    }
}