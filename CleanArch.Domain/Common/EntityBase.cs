using System.ComponentModel.DataAnnotations;

namespace CleanArch.Domain.Common;

public interface IEntityBase<TKey>
{
	[Key]
	public TKey Id { get; set; }
}

public abstract class EntityBase<TKey> : IEntityBase<TKey>
{
	public required TKey Id { get; set; }
	public DateTime CreatedAt { get; set; }
	public string? CreatedBy { get; set; }
	public DateTime ModifiedAt { get; set; }
	public string? ModifiedBy { get; set; }
}