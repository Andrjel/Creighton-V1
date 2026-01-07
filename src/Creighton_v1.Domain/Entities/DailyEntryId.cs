using Creighton_v1.Shared.Abstractions.Domain;

namespace Creighton_v1.Domain.Entities;

public sealed record DailyEntryId(Guid Value) : TypedIdValueBase(Value)
{
    public static implicit operator DailyEntryId(Guid value) => new(value);

    public static implicit operator Guid(DailyEntryId id) => id.Value;
}
