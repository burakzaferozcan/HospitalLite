using HL.Core.Common;

namespace HL.Core.Entities;

public class UserClaim : BaseEntity
{
    public int AppUserId { get; set; }
    public string ClaimType { get; set; } = string.Empty; // Permssion / Feature
    public string ClaimValue { get; set; } = string.Empty; // ÖRN: "Laboratory.Read"
}
