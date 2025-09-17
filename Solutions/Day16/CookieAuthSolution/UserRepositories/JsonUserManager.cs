namespace UserRepositories;

using UserEntities;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class JsonUserManager
{
    private static string GetJsonFilePath()
    {
        return Path.Combine(Directory.GetCurrentDirectory(), "Data", "users.json");
    }

    public static IEnumerable<User>? LoadUsers()
    {
        var json = File.ReadAllText(GetJsonFilePath());
        return JsonSerializer.Deserialize<IEnumerable<User>>(json);
    }

}