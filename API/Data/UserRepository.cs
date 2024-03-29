using API.DTO;
using API.Entities;
using API.Interface;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace API.Data 
{
    public class UserRepository : IUserRepository
    {
    
        private DataContext _context;
        private readonly IMapper _mapper;

        public UserRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }      


        public async Task<IEnumerable<AppUser>> GetUsersAsync()
        {
            return await _context.Users
                                .Include(p => p.Photos)
                                .ToListAsync();
        }

        public async Task<AppUser> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<AppUser> GetUserByUserNameAsync(string userName)
        {
            return await _context.Users
                                 .Include(p => p.Photos)
                                 .SingleOrDefaultAsync(x=> x.UserName == userName);
        }

        public void Update(AppUser user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync()>0;
        }

        public async Task<IEnumerable<MemberDto>> GetMemebersAsync()
        {
            return await _context.Users
                   .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
                   .ToListAsync();
        }

        public  async Task<MemberDto> GetMemeberAsync(string userName)
        {
            return await _context.Users.Where(x => x.UserName == userName)
            .ProjectTo<MemberDto>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync();
        }
    }
}            