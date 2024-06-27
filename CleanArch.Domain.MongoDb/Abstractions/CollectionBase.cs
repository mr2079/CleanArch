using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CleanArch.Domain.MongoDB.Abstractions;

public abstract class CollectionBase
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    [BsonElement]
    public bool Deleted { get; set; }
    [BsonElement]
    public DateTime CreatedAt { get; set; }
    [BsonElement]
    public string? CreatedBy { get; set; }
    [BsonElement]
    public DateTime ModifiedAt { get; set; }
    [BsonElement]
    public string? ModifiedBy { get; set; }
}