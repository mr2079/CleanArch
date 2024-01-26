using FluentValidation;

namespace CleanArch.Application.Features.User.Commands;

public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
{
	public UpdateUserCommandValidator()
	{
		RuleFor(u => u.UserName)
			.NotNull()
			.NotEmpty().WithMessage("{UserName} is required!")
			.MaximumLength(50).WithMessage("{UserName} must not exceed 50 characters!");
	}
}