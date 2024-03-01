using CleanArch.Domain.MongoDB.Common;
using MongoDB.Bson.Serialization.Attributes;

namespace CleanArch.Domain.MongoDB.Collections.User;

public class AppUser : CollectionBase
{
    [BsonElement]
    public string? UserName { get; set; }
    [BsonElement]
    public string? FirstName { get; set; }
    [BsonElement]
    public string? LastName { get; set; }
    [BsonElement]
    [BsonDateTimeOptions(DateOnly = true)]
    public DateTime? DateOfBirth { get; set; }
}