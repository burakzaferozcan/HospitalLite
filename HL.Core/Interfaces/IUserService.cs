using HL.Core.DTOs;

namespace HL.Core.Interfaces;

public interface IUserService
{
    Task CreateAsync(CreateUserDto dto);
    Task UpdateRefreshToken(int userId,string refreshToken, DateTime expiration);
}
