using AutoMapper;
using CleanArch.Application.DTOs.User;
using CleanArch.Application.Features.User.Commands;
using CleanArch.Domain.SqlServer.Entities.AppUser;

namespace CleanArch.Application.Mapper;

public class UserProfile : Profile
{
	public UserProfile()
	{
		CreateMap<User, UserListItemDto>().ReverseMap();
		CreateMap<User, UpdateUserCommand>().ReverseMap();
	}
}