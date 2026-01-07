using Creighton_v1.Shared.Abstractions.Exceptions;

namespace Creighton_v1.Shared.Abstractions.Domain;

public class BusinessRuleValidationException(IBusinessRule brokenRule)
    : CreightonAppException(brokenRule.Message)
{
    public IBusinessRule BrokenRule { get; } = brokenRule;
    public string Details { get; } = brokenRule.Message;

    public override string ToString() => $"{BrokenRule.GetType().FullName}: {BrokenRule.Message}";
}
