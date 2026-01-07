using Creighton_v1.Domain.Enums;
using Creighton_v1.Shared.Abstractions.Domain;

namespace Creighton_v1.Domain.ValueObjects;

public sealed record Observation() : ValueObject
{
    public bool HasBlood { get; init; }
    public BleedingIntensity? BleedingIntensity { get; init; }
    public MucusTypes? MucusType { get; init; }
    public ObservationFrequency? Frequency { get; init; }
}
