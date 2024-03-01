using CleanArch.Domain.SqlServer.Common;
using CleanArch.Domain.SqlServer.Entities.AppUser;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infrastructure.Persistence;

public class SqlServerContext : IdentityDbContext<User, Role, long>
{
	public SqlServerContext() {}
	public SqlServerContext(DbContextOptions<SqlServerContext> options)
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