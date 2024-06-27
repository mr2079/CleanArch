namespace CleanArch.Domain.SqlServer.Abstractions;

public interface IUnitOfWork
{
	Task<int> SaveChangesAsync(CancellationToken  cancellationToken = default);
}