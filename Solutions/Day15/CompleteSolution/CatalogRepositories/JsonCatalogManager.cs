namespace CatalogRepositories;

using CatalogEntities;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class JsonCatalogManager
{
    private static string GetJsonFilePath()
    {
        return Path.Combine(Directory.GetCurrentDirectory(), "Data", "products.json");
    }

    public static IEnumerable<Product>? LoadProducts()
    {
        var json = File.ReadAllText(GetJsonFilePath());
        return JsonSerializer.Deserialize<IEnumerable<Product>>(json);
    }

    public static void SaveProducts(IEnumerable<Product> products)
    {
        var json = JsonSerializer.Serialize(products);
        File.WriteAllText(GetJsonFilePath(), json);
    }
}