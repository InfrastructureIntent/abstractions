namespace InfrastructureIntent.Abstractions;

/// <summary>
/// Identifies a resource type within an Integration's domain.
/// </summary>
/// <param name="Value">The stable resource type identifier.</param>
public readonly record struct ResourceType(string Value)
{
    /// <summary>Returns the stable resource type identifier.</summary>
    public override string ToString() => Value;
}
