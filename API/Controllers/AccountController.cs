using System.Security.Cryptography;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;
        public AccountController(DataContext context)
        {
            _context = context;
        }
        [HttpPost("register")] //Post request api/Account/register
        public async Task<ActionResult<AppUser>> Register(String username,String password)
        {
            using var hmac = new HMACSHA512();
            var user = new AppUser
            {
                UserName = username,
                PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)),
                PasswordSalt = hmac.Key            
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }


    }
}