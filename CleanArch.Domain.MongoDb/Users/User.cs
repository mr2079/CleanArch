using CleanArch.Domain.MongoDB.Abstractions;
using CleanArch.Domain.Shared.ValueObjects;
using MongoDB.Bson.Serialization.Attributes;

namespace CleanArch.Domain.MongoDB.Users;

public sealed class User(
	string id,
	string userName,
	string email,
	FullName name,
	Address? address = null,
	bool isDeleted = false) : CollectionBase(id, isDeleted)
{
	[BsonElement]
	public string? UserName { get; private set; } = userName;
	[BsonElement]
	public string Email { get; private set; } = email;
	[BsonElement]
	public FullName Name { get; private set; } = name;
	[BsonElement]
	public Address? Address { get; private set; } = address;
}