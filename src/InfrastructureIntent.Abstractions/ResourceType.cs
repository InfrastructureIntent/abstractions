namespace InfrastructureIntent.Abstractions;

/// <summary>
/// Identifies a resource type within an Integration's domain.
/// </summary>
public readonly record struct ResourceType
{
    /// <summary>
    /// Initializes a new resource type identifier.
    /// </summary>
    /// <param name="value">The stable, non-empty resource type identifier.</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="value"/> is null, empty, or whitespace.</exception>
    public ResourceType(string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
        Value = value;
    }

    /// <summary>Gets the stable resource type identifier.</summary>
    public string Value { get; }

    /// <summary>Returns the stable resource type identifier.</summary>
    public override string ToString() => Value;
}
