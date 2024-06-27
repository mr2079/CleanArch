using CleanArch.Domain.SqlServer.Abstractions;
using CleanArch.Domain.SqlServer.Users.Events;

namespace CleanArch.Domain.SqlServer.Users;

public sealed class User(
	Guid id,
	string userName,
	string email,
	FullName name,
	Address? address = null) : EntityBase(id)
{
	public string UserName { get; private set; } = userName;
	public string Email { get; private set; } = email;
	public FullName Name { get; private set; } = name;
	public Address? Address { get; private set; } = address;

	public static User Create(string userName, string email, FullName name, Address? address = null)
	{
		var user = new User(Guid.NewGuid(), userName, email, name, address);

		user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));

		return user;
	}
}