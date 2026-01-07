namespace Creighton_v1.Domain.Attributes;

[AttributeUsage(AttributeTargets.Field)]
public sealed class CreightonSymbolAttribute(string symbol) : Attribute
{
    public string Symbol { get; } = symbol;
}