using HL.Core.Enums;

namespace HL.Core.DTOs;

public record UserDto(UserRole role, int Id, string FirstName, string LastName, string Email);
