using jadt.Domain.Entities.Auth;
using jadt.Domain.Interfaces.Repositories;
using jadt.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace jadt.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<User?> FindUserById(Guid id)
        {
            return _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public Task<User?> FindUserByEmail(string email)
        {
            return _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();  
        }
    }
}
