using HL.Core.DTOs;
using HL.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HL.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    private readonly IUserService _userService;

    public AuthController(IAuthService authService, IUserService userService)
    {
        _authService = authService;
        _userService = userService;
    }

    //yeni kullanıcı kaydı
    [HttpPost("register")]
    public async Task<ActionResult> Register(CreateUserDto createUserDto)
    {
        await _userService.CreateAsync(createUserDto);

        return Ok("Kullanıcı Başarıyla oluşturuldu giriş yapabilirsiniz");
    }

    //kullanıcı girişi
    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginDto loginDto)
    {
        var result = await _authService.LoginAsync(loginDto);
        return Ok(result);
    }

}
