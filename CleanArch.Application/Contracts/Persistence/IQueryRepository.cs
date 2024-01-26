using System.Linq.Expressions;
using CleanArch.Domain.Common;
using Microsoft.EntityFrameworkCore.Query;

namespace CleanArch.Application.Contracts.Persistence;

public interface IQueryRepository<TEntity, in TKey> where TEntity : IEntityBase<TKey>
{
	Task<IReadOnlyList<TEntity>> GetAsync(
		Expression<Func<TEntity, bool>>? predicate,
		Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy,
		List<Expression<Func<TEntity, object>>>? includesList,
		Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? thenIncludes,
		bool disableTracking = true);

	Task<TEntity> GetByIdAsync(TKey id);
}