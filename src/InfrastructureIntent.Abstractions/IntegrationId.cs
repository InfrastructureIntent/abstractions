namespace InfrastructureIntent.Abstractions;

/// <summary>
/// Identifies the infrastructure Integration that owns a resource's domain semantics.
/// </summary>
/// <param name="Value">The stable Integration identifier.</param>
public readonly record struct IntegrationId(string Value)
{
    /// <inheritdoc />
    public override string ToString() => Value;
}
