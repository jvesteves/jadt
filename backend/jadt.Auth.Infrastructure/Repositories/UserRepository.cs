using jadt.Auth.Domain.Entities;
using jadt.Auth.Domain.Interfaces.Repositories;
using jadt.Auth.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace jadt.Auth.Infrastructure.Repositories
{
    public class UserRepository(AuthDbContext context) : IUserRepository
    {
        public Task<User?> FindUserById(Guid id)
        {
            return context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public Task<User?> FindUserByEmail(string email)
        {
            return context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task CreateUser(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();  
        }
    }
}
