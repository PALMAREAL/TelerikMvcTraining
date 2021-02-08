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
                .ForMember(dest => dest.CategoryID, src => src.MapFrom(o => o.CategoryIDVm))
                .ForMember(dest => dest.CategoryName, src => src.MapFrom(o => o.CategoryNameVm))
                .ForMember(dest => dest.Description, src => src.MapFrom(o => o.DescriptionVm)).ReverseMap();
        }
    }
}