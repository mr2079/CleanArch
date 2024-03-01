using CleanArch.Domain.SqlServer.Common;

namespace CleanArch.Application.Contracts.Persistence;

public interface ICommandRepository<in TEntity, in TKey> where TEntity : IEntityBase<TKey>
{
	Task<bool> CreateAsync(TEntity entity);
	Task<bool> UpdateAsync(TEntity entity);
	Task<bool> DeleteAsync(TEntity entity);
	Task<bool> DeleteAsync(TKey id);
}