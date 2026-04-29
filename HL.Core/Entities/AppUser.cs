using HL.Core.Common;
using HL.Core.Enums;

namespace HL.Core.Entities;

public class AppUser : BaseEntity
{
    public required string FirstName { get; set; } = string.Empty;
    public required string LastName { get; set; } = string.Empty;
    public required string Email { get; set; } = string.Empty;
    public required string PasswordHash { get; set; } = string.Empty;
    public UserRole Role { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenEndDate { get; set; }
    public virtual ICollection<UserClaim> UserClaims { get; set; } = new List<UserClaim>();
}
