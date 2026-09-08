namespace InfrastructureIntent.Abstractions;

/// <summary>
/// Contains the Integration-owned canonical key used to distinguish a resource within its type.
/// </summary>
/// <param name="Value">The canonical Integration-defined resource key.</param>
public readonly record struct ResourceKey(string Value)
{
    /// <inheritdoc />
    public override string ToString() => Value;
}
