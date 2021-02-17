using AutoMapper;
using TelerikMvcTraining.Dtos;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.AutoMapper
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            MapAddress();
        }

        private void MapAddress()
        {
            CreateMap<Address, AddressDto>()
                .ForMember(dest => dest.Ciudad, act => act.MapFrom(src => src.City))
                .ForMember(dest => dest.Estado, act => act.MapFrom(src => src.State))
                .ForMember(dest => dest.País, act => act.MapFrom(src => src.Country))
                .ReverseMap()
                .ForPath(dest => dest.Country.CountryID, act => act.MapFrom(src => src.País.CountryID))
                .ForPath(dest => dest.Country.CountryNameShort, act => act.MapFrom(src => src.País.CountryNameShort))
                .ForPath(dest => dest.Country.CountryNameLong, act => act.MapFrom(src => src.País.CountryNameLong));
        }
    }
}