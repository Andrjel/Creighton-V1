namespace Creighton_v1.Shared.Abstractions.Domain;

public abstract class Entity<TId>
    where TId : TypedIdValueBase
{
    public TId Id { get; protected set; }
    private DateTime CreatedAt { get; } = DateTime.UtcNow;
    protected DateTime? UpdatedAt { get; }
    private List<IDomainEvent> _domainEvents = [];

    /// <summary>
    /// Domain events occurred.
    /// </summary>
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    /// <summary>
    /// Add domain event.
    /// </summary>
    /// <param name="domainEvent">Domain event.</param>
    protected void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    protected void CheckRule(IBusinessRule rule)
    {
        if (rule.IsBroken())
        {
            throw new BusinessRuleValidationException(rule);
        }
    }
}
