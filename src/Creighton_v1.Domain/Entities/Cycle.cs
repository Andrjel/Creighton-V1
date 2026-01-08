using Creighton_v1.Shared.Abstractions.Domain;

namespace Creighton_v1.Domain.Entities;

public class Cycle : Entity<CycleId>, IAggregateRoot
{
    private DateTime _startDate;
    private DateTime? _endDate;
    private readonly List<DailyEntry> _dailyEntries;
}
