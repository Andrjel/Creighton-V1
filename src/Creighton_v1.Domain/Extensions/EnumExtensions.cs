using System.Reflection;
using Creighton_v1.Domain.Attributes;
using Creighton_v1.Domain.Enums;

namespace Creighton_v1.Domain.Extensions;

public static class EnumExtensions
{
    public static string GetCreightonSymbol(this MucusTypes value)
    {
        return GetSymbolInternal(value);
    }

    public static string GetCreightonSymbol(this ObservationFrequency value)
    {
        return GetSymbolInternal(value);
    }

    private static string GetSymbolInternal<T>(T value)
        where T : Enum
    {
        Type type = typeof(T);
        string name = value.ToString();

        if (typeof(T) == typeof(MucusTypes) || typeof(T) == typeof(ObservationFrequency))
        {
            return name;
        }

        FieldInfo? field = type.GetField(name);

        if (field is null)
            return name;

        CreightonSymbolAttribute? attribute = field.GetCustomAttribute<CreightonSymbolAttribute>();
        return attribute?.Symbol ?? name;
    }
}
