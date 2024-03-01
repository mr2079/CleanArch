using System.ComponentModel.DataAnnotations;

namespace CleanArch.Domain.SqlServer.Common;

public interface IEntityBase<TKey>
{
	[Key]
	public TKey Id { get; set; }
	public bool Deleted { get; set; }
}

public abstract class EntityBase<TKey> : IEntityBase<TKey>
{
    public TKey Id { get; set; } = default!;
	public bool Deleted { get; set; }
	public DateTime CreatedAt { get; set; }
	public string? CreatedBy { get; set; }
	public DateTime ModifiedAt { get; set; }
	public string? ModifiedBy { get; set; }
}