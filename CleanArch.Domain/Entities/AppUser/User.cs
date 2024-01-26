using CleanArch.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace CleanArch.Domain.Entities.AppUser;

public class User : IdentityUser<long>, IEntityBase<long>;