 using CleanArch.Domain.SqlServer.Common;
using Microsoft.AspNetCore.Identity;

namespace CleanArch.Domain.SqlServer.Entities.AppUser;

public class User : IdentityUser<long>, IEntityBase<long>
{
	public bool Deleted { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public bool IsConfirm { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiryTime { get; set; }
}