using Creighton_v1.Domain.Enums;

namespace Creighton_v1.Domain.Consts;

public static class Consts
{
    public const MucusTypes PeakMucus =
        MucusTypes.Stretchy
        | MucusTypes.Clear
        | MucusTypes.Lubricative
        | MucusTypes.DampWithLubrication
        | MucusTypes.ShinyWithLubrication
        | MucusTypes.WetWithLubrication;

    public const MucusTypes PossibleFertileMucus =
        MucusTypes.Sticky
        | MucusTypes.Tacky
        | MucusTypes.Stretchy
        | MucusTypes.DampWithLubrication
        | MucusTypes.ShinyWithLubrication
        | MucusTypes.WetWithLubrication
        | MucusTypes.Cloudy
        | MucusTypes.CloudyClear
        | MucusTypes.Gummy
        | MucusTypes.Clear
        | MucusTypes.Lubricative
        | MucusTypes.Pasty
        | MucusTypes.Yellow;

    public const MucusTypes DryMucus =
        MucusTypes.Dry
        | MucusTypes.DampWithoutLubrication
        | MucusTypes.WetWithoutLubrication
        | MucusTypes.ShinyWithoutLubrication;
}
