
namespace Repositories;
 using Entities;
using System.Collections.Generic;
public interface IProductRepository
{

    IEnumerable<Product> GetAllProducts();
        Product AddProduct(Product product);
        // Product GetProductById(int id);
    // void AddProduct(Product product);
    // void UpdateProduct(Product product);
    // void DeleteProduct(int id);
}