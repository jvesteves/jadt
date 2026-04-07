using jadt.Auth.Application.DTOs;
using jadt.Auth.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace jadt.API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _service;

        public AuthController(AuthService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest)
        {
            await _service.Register(registerRequest);
            return Ok("Successfully registered.");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var token = await _service.Login(loginRequest);
            return Ok(new { token });
        }
    }
}
