namespace InfrastructureIntent.Abstractions;

/// <summary>
/// Contains the Integration-owned canonical key used to distinguish a resource within its type.
/// </summary>
public readonly record struct ResourceKey
{
    /// <summary>
    /// Initializes a new canonical resource key.
    /// </summary>
    /// <param name="value">The non-empty Integration-defined resource key.</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="value"/> is null, empty, or whitespace.</exception>
    public ResourceKey(string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
        Value = value;
    }

    /// <summary>Gets the canonical Integration-defined resource key.</summary>
    public string Value { get; }

    /// <summary>Returns the canonical Integration-defined resource key.</summary>
    public override string ToString() => Value;
}
