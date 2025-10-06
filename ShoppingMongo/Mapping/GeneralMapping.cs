using AutoMapper;
using ShoppingMongo.DTOS.CategoryDtos;
using ShoppingMongo.DTOS.NewsletterDtos;
using ShoppingMongo.DTOS.ProductDtos;
using ShoppingMongo.DTOS.ProductImageDtos;
using ShoppingMongo.DTOS.SliderDtos;
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

            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryByIdDto>().ReverseMap();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();

            CreateMap<ResultCategoryDto, GetCategoryByIdDto>().ReverseMap();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductByIdDto>().ReverseMap();
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<ResultProductDto, GetProductByIdDto>().ReverseMap();

            CreateMap<ProductImage, CreateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, UpdateProductImageDto>().ReverseMap();
            CreateMap<ProductImage, GetProductImageDto>().ReverseMap();
            CreateMap<ProductImage, ResultProductImageDto>().ReverseMap();

            CreateMap<Newsletter, CreateNewsletterDto>().ReverseMap();
        }
    }
}
