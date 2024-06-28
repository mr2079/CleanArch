using CleanArch.Domain.SqlServer.Abstractions;

namespace CleanArch.Domain.SqlServer.Users.Events;

public sealed record UserCreatedDomainEvent(string UserId) : IDomainEvent;