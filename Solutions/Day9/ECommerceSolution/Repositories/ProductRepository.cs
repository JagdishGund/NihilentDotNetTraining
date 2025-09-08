namespace Repositories;
using System.Collections.Generic;
using Entities;
using System.Collections.Generic;

using System.Text.Json;
using System.IO;
//CRUD Operations agains List Colllection
public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new List<Product>();
    string path = @"C:\CodeBase-Nihilent\MyDotnetTraining\NihilentDotNetTraining\Solutions\Day9\ECommerceSolution\products.json";
    public ProductRepository()
    {

    }
    public IEnumerable<Product> GetAllProducts()
    {
        

        string jsonStringFromFile = File.ReadAllText(path);
        // Console.WriteLine("File Data New APP" + jsonStringFromFile);
        List<Product>? productsFromFile = JsonSerializer.Deserialize<List<Product>>(jsonStringFromFile);
        return productsFromFile;

    }

    //   public static void SaveAllProducts(List<Product> products)
    //     {
    //         var jsonData = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
    //         File.WriteAllText(filePath, jsonData);
    //     }

    // public Product GetProductById(int id)
    // {
    //     return GetAllProducts().FirstOrDefault(p => p.Id == id);
    // }

   public Product AddProduct(Product product)
    {
        product.Id = _products.Count + 1; // Simulate DB auto-increment
        _products.Add(product);
        Console.WriteLine("Add" + product);
        string jsonString = JsonSerializer.Serialize(product);
        File.WriteAllText(path, jsonString);
        return product;
    }

    // public void UpdateProduct(Product product)
    // {
    //     var products = GetAllProducts();
    //         var index = products.FindIndex(p => p.Id == product.Id);
    //         if (index != -1)
    //         {
    //             products[index] = product;
    //             SaveAllProducts(products);
    //         }
    // }

    // public void DeleteProduct(int id)
    // {
    
    //     var products = GetAllProducts();
    //         var product = products.FirstOrDefault(p => p.Id == id);
    //         if (product != null)
    //         {
    //             products.Remove(product);
    //             SaveAllProducts(products);
    //         }
    // }
}