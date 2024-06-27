using CleanArch.Domain.SqlServer.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infrastructure.Data;

public class SqlServerContext : DbContext
{
	public SqlServerContext() {}
	public SqlServerContext(DbContextOptions<SqlServerContext> options)
		: base(options) {}

	public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
	{
		foreach (var entry in ChangeTracker.Entries<EntityBase>())
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