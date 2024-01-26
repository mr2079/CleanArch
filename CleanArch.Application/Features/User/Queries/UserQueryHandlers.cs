using CleanArch.Application.DTOs.User;
using MediatR;

namespace CleanArch.Application.Features.User.Queries;

public class GetUsersListQueryHandler : IRequestHandler<GetUsersListQuery, UserListDto>
{
	public Task<UserListDto> Handle(GetUsersListQuery request, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}
}