using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;
public static class Seed
{
    public static async Task SeedUsers(DataContext Context)
    {
        if( await Context.Users.AnyAsync()) return;
        
        var UserData = await File.ReadAllTextAsync("Data/UserSeedData.json");
        var Options  = new JsonSerializerOptions{ PropertyNameCaseInsensitive = true};
        var users    = JsonSerializer.Deserialize<List<AppUser>>(UserData);
        foreach (var user in users)
        {
            using var hmac = new HMACSHA512();
            user.UserName  = user.UserName.ToLower();
            user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("pa$$word"));
            user.PasswordSalt = hmac.Key;
            Context.Add(user);
        }
        await Context.SaveChangesAsync();
    }
}