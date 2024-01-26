using MediatR;

namespace CleanArch.Application.Features.User.Commands;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
{
	public Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}