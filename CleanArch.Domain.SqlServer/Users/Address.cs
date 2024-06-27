namespace CleanArch.Domain.SqlServer.Users;

public record Address(
	string Country,
	string State,
	string ZipCode,
	string City,
	string Street);