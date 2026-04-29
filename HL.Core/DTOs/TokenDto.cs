namespace HL.Core.DTOs;

public record TokenDto(string AccessToken, DateTime RefreshTokenExpiration, string RefreshToken);
