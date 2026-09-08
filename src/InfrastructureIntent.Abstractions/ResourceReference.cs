namespace InfrastructureIntent.Abstractions;

/// <summary>
/// Represents a strongly typed, identity-based reference to a domain semantic contract.
/// </summary>
/// <typeparam name="TDomain">The expected Integration-owned domain contract.</typeparam>
/// <param name="Identity">The canonical identity of the referenced resource.</param>
public readonly record struct ResourceReference<TDomain>(ResourceIdentity Identity)
    where TDomain : IResourceNode;
