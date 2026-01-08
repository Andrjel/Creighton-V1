using Creighton_v1.Domain.Attributes;

namespace Creighton_v1.Domain.Enums;

/// <summary>
/// Bleeding intensity.
/// </summary>
[Flags]
public enum BleedingIntensity
{
    None = 0,

    [CreightonSymbol("B")]
    Brown = 1 << 0,

    [CreightonSymbol("VL")]
    VeryLow = 1 << 1,

    [CreightonSymbol("L")]
    Low = 1 << 2,

    [CreightonSymbol("M")]
    Medium = 1 << 3,

    [CreightonSymbol("H")]
    High = 1 << 4,
}
