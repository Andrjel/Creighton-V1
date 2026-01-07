namespace Creighton_v1.Shared.Abstractions.Domain;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public sealed class IgnoreMemberAttribute : Attribute { }
