using CleanArch.Domain.SqlServer.Abstractions;
using MediatR;

namespace CleanArch.Application.Abstractions.Messaging;

public interface ICommandBase;

public interface ICommand : IRequest<Result>, ICommandBase;

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, ICommandBase;