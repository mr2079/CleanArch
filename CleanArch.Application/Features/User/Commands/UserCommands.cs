using MediatR;

namespace CleanArch.Application.Features.User.Commands;

public class UpdateUserCommand : IRequest<bool>
{
	public string UserName { get; set; } = default!;
	public string Password { get; set; } = default!;
}