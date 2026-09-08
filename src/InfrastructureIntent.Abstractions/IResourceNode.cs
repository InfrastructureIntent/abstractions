namespace InfrastructureIntent.Abstractions;

/// <summary>
/// Defines the minimum common contract for a node that participates in an InfrastructureIntent Resource Graph.
/// </summary>
public interface IResourceNode
{
    /// <summary>Gets the node's authoritative resource identity.</summary>
    ResourceIdentity Identity { get; }

    /// <summary>Gets the node's canonical resource type.</summary>
    ResourceType Type { get; }
}
