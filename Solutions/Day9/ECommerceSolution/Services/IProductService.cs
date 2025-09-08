namespace Services
{
    using Entities;
    using System.Collections.Generic;
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        Product AddProduct(Product product);
        bool UpdateProduct(int id,Product product);
        bool DeleteProduct(int id);
    }
}