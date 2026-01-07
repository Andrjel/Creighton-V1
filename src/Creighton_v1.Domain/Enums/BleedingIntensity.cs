namespace Creighton_v1.Domain.Enums;

/// <summary>
/// Bleeding intensity.
/// </summary>
[Flags]
public enum BleedingIntensity
{
    None = 0,
    Brown = 1 << 0,
    VeryLow = 1 << 1,
    Low = 1 << 2,
    Medium = 1 << 3,
    High = 1 << 4,
}
