using Creighton_v1.Domain.Attributes;

namespace Creighton_v1.Domain.Enums;

[Flags]
public enum ObservationFrequency
{
    [CreightonSymbol("X1")]
    One = 1,

    [CreightonSymbol("X2")]
    Two = 1 << 1,

    [CreightonSymbol("X3")]
    Three = 1 << 3,

    [CreightonSymbol("AD")]
    AllDay = 1 << 4,
}
