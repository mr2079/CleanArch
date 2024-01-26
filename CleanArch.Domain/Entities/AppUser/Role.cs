using CleanArch.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace CleanArch.Domain.Entities.AppUser;

public class Role : IdentityRole<long>, IEntityBase<long>;