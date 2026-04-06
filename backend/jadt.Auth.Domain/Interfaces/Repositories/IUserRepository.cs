using jadt.Auth.Domain.Entities;

namespace jadt.Auth.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User?> FindUserById(Guid id);
        Task<User?> FindUserByEmail(string email);
        Task CreateUser(User user);
    }
}
