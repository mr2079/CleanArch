using MongoDB.Bson.Serialization.Attributes;

namespace CleanArch.Domain.MongoDB.Abstractions;

public abstract class CollectionBase(
	string id,
	bool isDeleted = false)
{
	public string Id { get; set; } = id;
	[BsonElement] public bool IsDeleted { get; set; } = isDeleted;
    [BsonElement] public DateTime CreatedAt { get; set; }
    [BsonElement] public DateTime ModifiedAt { get; set; }
}