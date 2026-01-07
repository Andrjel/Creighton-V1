namespace Creighton_v1.Shared.Abstractions.Domain;

public abstract class DomainEventBase : IDomainEvent
{
    protected DomainEventBase()
    {
        Id = Guid.NewGuid();
        OccuredOn = DateTime.UtcNow;
    }

    public Guid Id { get; }
    public DateTime OccuredOn { get; }
}
