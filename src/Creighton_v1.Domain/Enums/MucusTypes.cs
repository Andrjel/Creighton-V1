using Creighton_v1.Domain.Attributes;

namespace Creighton_v1.Domain.Enums;

/// <summary>
/// Mucus type.
/// </summary>
[Flags]
public enum MucusTypes
{
    Dry = 0,

    [CreightonSymbol("2")]
    DampWithoutLubrication = 1 << 0,

    [CreightonSymbol("2W")]
    WetWithoutLubrication = 1 << 1,

    [CreightonSymbol("4")]
    ShinyWithoutLubrication = 1 << 2,

    [CreightonSymbol("6")]
    Sticky = 1 << 3,

    [CreightonSymbol("8")]
    Tacky = 1 << 4,

    [CreightonSymbol("10")]
    Stretchy = 1 << 5,

    [CreightonSymbol("10DL")]
    DampWithLubrication = 1 << 6,

    [CreightonSymbol("10SL")]
    ShinyWithLubrication = 1 << 7,

    [CreightonSymbol("10WL")]
    WetWithLubrication = 1 << 8,

    [CreightonSymbol("B")]
    Brown = 1 << 9,

    [CreightonSymbol("C")]
    Cloudy = 1 << 10,

    [CreightonSymbol("C/K")]
    CloudyClear = 1 << 11,

    [CreightonSymbol("G")]
    Gummy = 1 << 12,

    [CreightonSymbol("K")]
    Clear = 1 << 13,

    [CreightonSymbol("L")]
    Lubricative = 1 << 14,

    [CreightonSymbol("P")]
    Pasty = 1 << 15,

    [CreightonSymbol("R")]
    Red = 1 << 16,

    [CreightonSymbol("Y")]
    Yellow = 1 << 17,
}
