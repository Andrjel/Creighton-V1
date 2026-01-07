namespace Creighton_v1.Domain.Enums;

/// <summary>
/// Creighton stamp type.
/// </summary>
[Flags]
public enum StampTypes
{
    None = 0,
    Green = 1 << 0, // 1
    White = 1 << 1, // 2
    Yellow = 1 << 2, // 4
    Red = 1 << 3, // 8
    Baby = 1 << 4, // 16
    GreenBaby = Green | Baby,
    WhiteBaby = White | Baby,
}
