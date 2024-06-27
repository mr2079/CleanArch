namespace CleanArch.Domain.SqlServer.Abstractions;

public abstract class Entity(Guid id)
{
	private readonly List<IDomainEvent> _domainEvents = new();

	public Guid Id { get; set; } = id;
	public DateTime CreatedAt { get; set; }
	public DateTime ModifiedAt { get; set; }

	public IReadOnlyList<IDomainEvent> GetDomainEvents()
	{
		return _domainEvents.ToList();
	}

	public void ClearDomainEvents()
	{
		_domainEvents.Clear();
	}

	protected void RaiseDomainEvent(IDomainEvent domainEvent)
	{
		_domainEvents.Add(domainEvent);
	}
}