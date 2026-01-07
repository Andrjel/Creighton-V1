namespace Creighton_v1.Shared.Abstractions.Domain;

public interface IBusinessRule
{
    string Message { get; }
    bool IsBroken();
}
