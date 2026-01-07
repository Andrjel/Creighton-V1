using Creighton_v1.Shared.Abstractions.Domain;

namespace Creighton_v1.Domain.Entities;

public sealed record UserId(Guid Value) : TypedIdValueBase(Value)
{
    public static implicit operator UserId(Guid value) => new(value);

    public static implicit operator Guid(UserId id) => id.Value;
}
