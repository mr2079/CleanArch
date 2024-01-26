using CleanArch.Domain.Common;
using CleanArch.Domain.Entities.AppUser;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infrastructure.Persistence;

public class ApplicationContext : IdentityDbContext<User, Role, long>
{
	public ApplicationContext() {}
	public ApplicationContext(DbContextOptions<ApplicationContext> options)
		: base(options) {}

	public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
	{
		foreach (var entry in ChangeTracker.Entries<EntityBase<long>>())
		{
			switch (entry.State)
			{
				case EntityState.Added:
					entry.Entity.CreatedAt = DateTime.Now;
					entry.Entity.ModifiedAt = entry.Entity.CreatedAt;
					break;
				case EntityState.Modified:
					entry.Entity.ModifiedAt = DateTime.Now;
					break;
			}
		}

		return base.SaveChangesAsync(cancellationToken);
	}
}