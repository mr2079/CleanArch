namespace CleanArch.Domain.SqlServer.Abstractions;

public abstract class EntityBase(
	string id,
	bool isDeleted = false)
{
	private readonly List<IDomainEvent> _domainEvents = new();

	public string Id { get; set; } = id;
	public DateTime CreatedAt { get; set; }
	public DateTime ModifiedAt { get; set; }
	public bool IsDeleted { get; set; } = isDeleted;

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