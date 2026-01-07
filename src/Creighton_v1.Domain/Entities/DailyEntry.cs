using Creighton_v1.Domain.Enums;
using Creighton_v1.Domain.ValueObjects;
using Creighton_v1.Shared.Abstractions.Domain;

namespace Creighton_v1.Domain.Entities;

public class DailyEntry : Entity<DailyEntryId>
{
    public DateOnly Date { get; private set; }
    public StampTypes? Stamp { get; private set; }
    public Observation? Observation { get; private set; }
}
