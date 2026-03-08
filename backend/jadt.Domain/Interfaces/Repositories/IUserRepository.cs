using jadt.Domain.Entities.Auth;

namespace jadt.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User?> FindUserById(Guid id);
        Task<User?> FindUserByEmail(string email);
        Task CreateUser(User user);
    }
}
