namespace CRMRepositories;

using CRMEntities;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class JsonCustomerManager
{
    private static string GetJsonFilePath()
    {
        return Path.Combine(Directory.GetCurrentDirectory(), "Data", "customers.json");
    }

    public static IEnumerable<Customer>? LoadCustomers()
    {
        var json = File.ReadAllText(GetJsonFilePath());
        return JsonSerializer.Deserialize<IEnumerable<Customer>>(json);
    }

    public static void SaveCustomers(IEnumerable<Customer> customers)
    {
        var json = JsonSerializer.Serialize(customers);
        File.WriteAllText(GetJsonFilePath(), json);
    }
}