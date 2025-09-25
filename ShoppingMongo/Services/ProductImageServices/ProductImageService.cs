using AutoMapper;
using MongoDB.Driver;
using ShoppingMongo.DTOS.ProductImageDtos;
using ShoppingMongo.Entities;

namespace ShoppingMongo.Services.ProductImageServices
{
    public class ProductImageService : IProductImageService
    {
        private readonly IMongoCollection<ProductImage> _collection;
        private readonly IMapper _mapper;

        public ProductImageService(IMongoDatabase databasesettings, IMapper mapper)
        {
            _collection = databasesettings.GetCollection<ProductImage>("ProductImages");
            _mapper = mapper;
        }


        public Task<string?> GetProductImageByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}