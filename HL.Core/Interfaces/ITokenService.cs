using HL.Core.DTOs;
using HL.Core.Entities;

namespace HL.Core.Interfaces;

public interface ITokenService
{
    TokenDto CreateToken(AppUser user);
}