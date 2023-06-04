using System.Collections;
using API.Data;
using API.DTO;
using API.Entities;
using API.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize]
     public class UsersController : BaseApiController
    {
        private IUserRepository _userRepository;
        private IMapper _mapper;

        public UsersController(IUserRepository userRepository,IMapper mapper)
        {
            _userRepository = userRepository;  
            _mapper = mapper;         
        }
        
        [HttpGet]
       public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            var users =  await _userRepository.GetMemebersAsync();
            return Ok(users);
            
        }
         [AllowAnonymous]
        [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        {
            return await _userRepository.GetMemeberAsync(username);
            
        }
    }
}