using HL.Core.DTOs;

namespace HL.Core.Interfaces;

public interface IAuthService
{
    Task<TokenDto> LoginAsync(LoginDto loginDto);
}