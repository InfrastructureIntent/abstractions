namespace InfrastructureIntent.Abstractions;

/// <summary>
/// Identifies a resource type within an Integration's domain.
/// </summary>
/// <param name="Value">The stable resource type identifier.</param>
public readonly record struct ResourceType(string Value)
{
    /// <inheritdoc />
    public override string ToString() => Value;
}
