using AutoMapper;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.AutoMapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            MapCategory();
        }

        private void MapCategory()
        {
            CreateMap<Category, CategoryViewModel>()
                .ForMember(dest => dest.CategoryIDVm, act => act.MapFrom(src => src.CategoryID))
                .ForMember(dest => dest.CategoryNameVm, act => act.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.DescriptionVm, act => act.MapFrom(src => src.Description)).ReverseMap();
        }
    }
}