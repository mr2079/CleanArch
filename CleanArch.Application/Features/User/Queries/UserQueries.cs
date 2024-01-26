using CleanArch.Application.DTOs.User;
using MediatR;

namespace CleanArch.Application.Features.User.Queries;

public class GetUsersListQuery : IRequest<UserListDto>
{
	public string UserName { get; set; }

	public GetUsersListQuery(string userName)
	{
		UserName = userName;
	}
}