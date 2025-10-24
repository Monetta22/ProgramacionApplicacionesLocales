using System.Text.Json;
using ev3.Models;

namespace ev3.Services;

public class UserRepository
{
    private readonly string _filePath;
    private readonly JsonSerializerOptions _options = new(JsonSerializerDefaults.Web) { WriteIndented = true };

    public UserRepository(string? filePath = null)
    {
        _filePath = filePath ?? Path.Combine(AppContext.BaseDirectory, "users.json");
        EnsureFile();
    }

    private void EnsureFile()
    {
        if (!File.Exists(_filePath))
        {
            var empty = new List<User>();
            File.WriteAllText(_filePath, JsonSerializer.Serialize(empty, _options));
        }
    }

    private List<User> Load()
    {
        var json = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<User>>(json, _options) ?? new List<User>();
    }

    private void Save(List<User> users)
    {
        File.WriteAllText(_filePath, JsonSerializer.Serialize(users, _options));
    }

    public bool Validate(string email, string password)
    {
        var users = Load();
        return users.Any(u => string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase) && u.Password == password);
    }

    public bool Register(string email, string password)
    {
        var users = Load();
        if (users.Any(u => string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase)))
            return false;
        users.Add(new User { Email = email, Password = password });
        Save(users);
        return true;
    }
}
