namespace Creighton_v1.Shared.Abstractions.Domain;

public abstract record TypedIdValueBase
{
    protected Guid Value { get; }

    protected TypedIdValueBase(Guid value)
    {
        if (value == Guid.Empty)
            throw new InvalidOperationException("Id cannot be empty.");
        Value = value;
    }
}
