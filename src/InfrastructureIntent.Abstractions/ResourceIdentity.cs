namespace InfrastructureIntent.Abstractions;

/// <summary>
/// Provides the authoritative Target-independent identity of a resource node.
/// </summary>
/// <param name="Integration">The Integration that owns the domain semantics.</param>
/// <param name="Type">The canonical resource type.</param>
/// <param name="Key">The Integration-owned canonical resource key.</param>
public readonly record struct ResourceIdentity(
    IntegrationId Integration,
    ResourceType Type,
    ResourceKey Key);
