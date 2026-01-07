using Creighton_v1.Shared.Abstractions.Domain;

namespace Creighton_v1.Domain.Entities;

public class Cycle : Entity<CycleId>, IAggregateRoot
{
    public DateTime StartDate { get; private set; }
    public DateTime? EndDate { get; private set; }
    public DateTime PeakDate { get; private set; }
    public List<DailyEntry> DailyEntries { get; private set; }
}
