using CleanArch.Domain.MongoDB.Abstractions;
using MongoDB.Bson.Serialization.Attributes;

namespace CleanArch.Domain.MongoDB.Users;

public class User : CollectionBase
{
    [BsonElement]
    public string? UserName { get; set; }
    [BsonElement]
    public string? FirstName { get; set; }
    [BsonElement]
    public string? LastName { get; set; }
}