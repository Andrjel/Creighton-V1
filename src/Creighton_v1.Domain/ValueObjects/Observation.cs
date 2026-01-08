using Creighton_v1.Domain.Consts;
using Creighton_v1.Domain.Enums;
using Creighton_v1.Shared.Abstractions.Domain;

namespace Creighton_v1.Domain.ValueObjects;

public sealed record Observation(
    BleedingIntensity? BleedingIntensity,
    MucusTypes MucusType,
    ObservationFrequency? Frequency
) : ValueObject { }
