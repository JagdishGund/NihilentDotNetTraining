namespace FileReadWrite.Repository;
using System.Collections.Generic;
using FileReadWrite.Entities;
using System.Collections.Generic;

using System.Text.Json;
using System.IO;
//CRUD Operations agains List Colllection
public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new List<Product>();

   // private static string filePath = File.ReadAllText("./App_Data/products.json");
    public ProductRepository()
    {
       
    }
    public IEnumerable<Product> GetAllProducts()
    {
        string path = @"C:\CodeBase-Nihilent\MyDotnetTraining\NihilentDotNetTraining\Solutions\Day9\WebApplication\FileReadWrite\App_Data\products.json";

        string jsonStringFromFile = File.ReadAllText(path);
        Console.WriteLine("File Data" + jsonStringFromFile);
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

    // public void AddProduct(Product product)
    // {
    //    var products = GetAllProducts();
    //         product.Id = products.Count >= 0 ? products.Max(p => p.Id) + 1 : 1;
    //         products.Add(product);
    //         SaveAllProducts(products);
    // }

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