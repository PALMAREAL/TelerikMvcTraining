using AutoMapper;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.AutoMapper
{
    public class ProductDetailProfile : Profile
    {
        public ProductDetailProfile()
        {
            MapProductDetail();
        }

        private void MapProductDetail()
        {
            CreateMap<DetailProduct, DetailProductViewModel>()
               .ForMember(dest => dest.ProductID, act => act.MapFrom(src => src.ProductID))
               .ForMember(dest => dest.UnitPrice, act => act.MapFrom(src => src.UnitPrice))
               .ForMember(dest => dest.UnitsInStock, act => act.MapFrom(src => src.UnitsInStock))
               .ForMember(dest => dest.QuantityPerUnit, act => act.MapFrom(src => src.QuantityPerUnit))
               .ForMember(dest => dest.Discontinued, act => act.MapFrom(src => src.Discontinued))
               .ForMember(dest => dest.UnitsOnOrder, act => act.MapFrom(src => src.UnitsOnOrder))
               .ForMember(dest => dest.CategoryID, act => act.MapFrom(src => src.CategoryID))
               .ForMember(dest => dest.CountryID, act => act.MapFrom(src => src.CountryID))
               .ForMember(dest => dest.CustomerRating, act => act.MapFrom(src => src.CustomerRating))
               .ForMember(dest => dest.TargetSales, act => act.MapFrom(src => src.TargetSales))
               .ForMember(dest => dest.LastSupply, act => act.MapFrom(src => src.LastSupply))
               .ForMember(dest => dest.Category, act => act.MapFrom(src => src.Category))
               .ForMember(dest => dest.Country, act => act.MapFrom(src => src.Country))
               .ReverseMap()
               .ForPath(dest => dest.Category.CategoryID, act => act.MapFrom(src => src.Category.CategoryIDVm))
               .ForPath(dest => dest.Category.CategoryName, act => act.MapFrom(src => src.Category.CategoryNameVm))
               .ForPath(dest => dest.Category.Description, act => act.MapFrom(src => src.Category.DescriptionVm))
               .ForPath(dest => dest.Category.Picture, act => act.MapFrom(src => src.Category.PictureVm))
               .ForPath(dest => dest.Country.CountryID, act => act.MapFrom(src => src.Country.CountryID))
               .ForPath(dest => dest.Country.CountryNameShort, act => act.MapFrom(src => src.Country.CountryNameShort))
               .ForPath(dest => dest.Country.CountryNameLong, act => act.MapFrom(src => src.Country.CountryNameLong));
        }
    }
}

