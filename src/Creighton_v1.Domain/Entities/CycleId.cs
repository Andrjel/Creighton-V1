using Creighton_v1.Shared.Abstractions.Domain;

namespace Creighton_v1.Domain.Entities;

public sealed record CycleId(Guid Value) : TypedIdValueBase(Value)
{
    public static implicit operator CycleId(Guid value) => new(value);

    public static implicit operator Guid(CycleId cycleId) => cycleId.Value;
}
