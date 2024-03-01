using System.Linq.Expressions;
using CleanArch.Application.Contracts.Persistence;
using CleanArch.Domain.SqlServer.Common;
using Microsoft.EntityFrameworkCore.Query;

namespace CleanArch.Infrastructure.Implementation.Repositories;

public class QueryRepository<TEntity, TKey> : IQueryRepository<TEntity, TKey> where TEntity : IEntityBase<TKey>
{
	public Task<IReadOnlyList<TEntity>> GetAsync(
			Expression<Func<TEntity, bool>>? predicate,
			Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy,
			List<Expression<Func<TEntity, object>>>? includesList, Func<IQueryable<TEntity>,
			IIncludableQueryable<TEntity, object>>? thenIncludes,
			bool disableTracking = true)
	{
		throw new NotImplementedException();
	}

	public Task<TEntity> GetByIdAsync(TKey id)
	{
		throw new NotImplementedException();
	}
}