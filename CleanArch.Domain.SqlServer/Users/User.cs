using CleanArch.Domain.Shared.ValueObjects;
using CleanArch.Domain.SqlServer.Abstractions;
using CleanArch.Domain.SqlServer.Users.Events;

namespace CleanArch.Domain.SqlServer.Users;

public sealed class User(
	string id,
	string userName,
	string email,
	FullName name,
	Address? address = null,
	bool isDeleted = false) : EntityBase(id, isDeleted)
{
	public string UserName { get; private set; } = userName;
	public string Email { get; private set; } = email;
	public FullName Name { get; private set; } = name;
	public Address? Address { get; private set; } = address;

	public static User Create(
		string userName,
		string email,
		FullName name,
		Address? address = null,
		bool isDeleted = false)
	{
		var user = new User(
			Guid.NewGuid().ToString().Replace("-", string.Empty),
			userName,
			email,
			name,
			address,
			isDeleted);

		user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));

		return user;
	}
}