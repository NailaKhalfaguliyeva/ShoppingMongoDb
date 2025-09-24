using AutoMapper;
using MongoDB.Driver;
using ShoppingMongo.Entities;
using ShoppingMongo.Settings;

namespace ShoppingMongo.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {

        private readonly IMongoCollection<Category> _categoryCollection;

        public CategoryService(IDatabaseSettings settings)
        {

            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _categoryCollection = database.GetCollection<Category>(settings.CategoryCollectionName);
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _categoryCollection.Find(_ => true).ToListAsync();
        }

        public async Task<Category> GetByIdAsync(string id)
        {
            return await _categoryCollection.Find(x => x.CategoryId == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(Category category)
        {
            await _categoryCollection.InsertOneAsync(category);
        }

        public async Task UpdateAsync(Category category)
        {
            await _categoryCollection.ReplaceOneAsync(x => x.CategoryId == category.CategoryId, category);
        }

        public async Task DeleteAsync(string id)
        {
            await _categoryCollection.DeleteOneAsync(x => x.CategoryId == id);
        }
    }
}