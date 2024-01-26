using FluentValidation.Results;
using System.Collections.Concurrent;

namespace CleanArch.Application.Exceptions;

public class ApplicationValidationException() : ApplicationException("One or more validation failures occurred!")
{
	public IDictionary<string, string[]> Errors { get; set; } = new ConcurrentDictionary<string, string[]>();

	public ApplicationValidationException(IEnumerable<ValidationFailure> failures) : this()
	{
		Errors = failures.GroupBy(e => e.PropertyName, e => e.ErrorMessage)
			.ToDictionary(d => d.Key, d => d.ToArray());
	}
}