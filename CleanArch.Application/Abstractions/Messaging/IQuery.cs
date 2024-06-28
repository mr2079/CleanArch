using CleanArch.Domain.SqlServer.Abstractions;
using MediatR;

namespace CleanArch.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>;