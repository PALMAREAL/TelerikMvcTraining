using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            CreateMap<CategoryViewModel, Category>()
                .ForMember(dest => dest.CategoryID, o => o.MapFrom(src => src.CategoryIDVm))
                .ForMember(dest => dest.CategoryName, o => o.MapFrom(src => src.CategoryNameVm))
                .ForMember(dest => dest.Description, o => o.MapFrom(src => src.DescriptionVm)).ReverseMap();
        }
    }
}