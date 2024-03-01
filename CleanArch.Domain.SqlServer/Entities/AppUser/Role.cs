using CleanArch.Domain.SqlServer.Common;
using Microsoft.AspNetCore.Identity;

namespace CleanArch.Domain.SqlServer.Entities.AppUser;

public class Role : IdentityRole<long>, IEntityBase<long>
{
	public bool Deleted { get; set; }
}