using CleanArch.Domain.SqlServer.Abstractions;
using MediatR;

namespace CleanArch.Application.Abstractions.Messaging;

public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
	where TQuery : IQuery<TResponse>;