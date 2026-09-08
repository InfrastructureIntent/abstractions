namespace InfrastructureIntent.Abstractions;

/// <summary>
/// Identifies the infrastructure Integration that owns a resource's domain semantics.
/// </summary>
public readonly record struct IntegrationId
{
    /// <summary>
    /// Initializes a new Integration identifier.
    /// </summary>
    /// <param name="value">The stable, non-empty Integration identifier.</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="value"/> is null, empty, or whitespace.</exception>
    public IntegrationId(string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
        Value = value;
    }

    /// <summary>Gets the stable Integration identifier.</summary>
    public string Value { get; }

    /// <summary>Returns the stable Integration identifier.</summary>
    public override string ToString() => Value;
}
