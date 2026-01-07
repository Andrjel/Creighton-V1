namespace Creighton_v1.Shared.Abstractions.Domain;

public interface IDomainEvent
{
    Guid Id { get; }
    DateTime OccuredOn { get; }
}
