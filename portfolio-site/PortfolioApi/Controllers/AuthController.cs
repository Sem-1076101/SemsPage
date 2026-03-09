using Microsoft.AspNetCore.Mvc;
using PortfolioApi.DTO;
using PortfolioApi.Services;
using Microsoft.AspNetCore.Authorization;

namespace PortfolioApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase {

    // databse connection
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto request) {
        var resultRegister = await _authService.Register(request);

        if(!resultRegister)
            return BadRequest("Email is al in gebruik!");

        return Ok();
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginDto request) 
    {
        var token  = await _authService.LoginAsync(request);

        if (token == null) 
            return Unauthorized("Ongeldige inloggegevens");

        return Ok(new { token });
    }
    
}