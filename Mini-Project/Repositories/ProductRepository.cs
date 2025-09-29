namespace Repositories;
using MongoDB.Driver;
using Entities;
using Services;

public class ProductMongoRepository : IProductRepository
{
    private readonly IMongoCollection<Product> _products;

    public ProductMongoRepository(IOptions<MongoDBSettings> settings, IMongoClient client)
    {
        var database = client.GetDatabase(settings.Value.DatabaseName);
        _products = database.GetCollection<Product>(settings.Value.ProductsCollection);
    }

    public async Task<List<Product>> GetAllAsync() =>
        await _products.Find(p => true).ToListAsync();

    // public async Task<Product?> GetByIdAsync(string id) =>
    //     await _products.Find(p => p.Id == id).FirstOrDefaultAsync();

    // public async Task CreateAsync(Product product) =>
    //     await _products.InsertOneAsync(product);

    // public async Task UpdateAsync(string id, Product product) =>
    //     await _products.ReplaceOneAsync(p => p.Id == id, product);

    // public async Task DeleteAsync(string id) =>
    //     await _products.DeleteOneAsync(p => p.Id == id);
}