using jadt.Application.DTOs.Auth;
using jadt.Domain.Entities;
using jadt.Domain.Interfaces.Repositories;
using System.Security.Authentication;
namespace jadt.Application.Services
{
    public class AuthService
    {
        private readonly IUserRepository _userRepository;
        public AuthService(IUserRepository userRepository) {
        _userRepository = userRepository;
        }

        public async Task Register(RegisterRequest registerRequest)
        {
            var verifyRegisteredUser = await _userRepository.FindUserByEmail(registerRequest.Email);
            if (verifyRegisteredUser != null) 
            {
                throw new InvalidOperationException("An account with this email address already exists.");
            }

            User newUser = new User
            {
                Name = registerRequest.Name,
                Email = registerRequest.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(registerRequest.Password)
            };

            await _userRepository.CreateUser(newUser);

        }

        public async Task<string> Login(LoginRequest loginRequest)
        {
            var user = await _userRepository.FindUserByEmail(loginRequest.Email);

            if (user == null || !BCrypt.Net.BCrypt.Verify(loginRequest.Password, user.PasswordHash))
            {
                throw new AuthenticationException("Invalid email or password. Please try again.");
            }

            throw new NotImplementedException("Token section not implemented");
        }
    }
}
