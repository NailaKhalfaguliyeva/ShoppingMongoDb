using AutoMapper;
using ShoppingMongo.DTOS;
using ShoppingMongo.Entities;

namespace ShoppingMongo.Mapping
{
    public class GeneralMapping : Profile
    {
      public   GeneralMapping()
        {
            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
            CreateMap<Slider, GetSliderDto>().ReverseMap();
        }
    }
}
