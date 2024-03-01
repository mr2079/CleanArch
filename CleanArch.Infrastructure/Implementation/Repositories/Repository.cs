using CleanArch.Application.Contracts.Persistence;
using CleanArch.Domain.SqlServer.Common;

namespace CleanArch.Infrastructure.Implementation.Repositories;

public class Repository<TEntity, TKey> : QueryRepository<TEntity, TKey>, ICommandRepository<TEntity, TKey>
	where TEntity : IEntityBase<TKey>
{
	public Task<bool> CreateAsync(TEntity entity)
	{
		throw new NotImplementedException();
	}

	public Task<bool> UpdateAsync(TEntity entity)
	{
		throw new NotImplementedException();
	}

	public Task<bool> DeleteAsync(TEntity entity)
	{
		throw new NotImplementedException();
	}

	public Task<bool> DeleteAsync(TKey id)
	{
		throw new NotImplementedException();
	}
}