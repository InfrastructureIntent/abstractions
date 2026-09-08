namespace InfrastructureIntent.Abstractions;

/// <summary>
/// Marks a resource node as infrastructure asserted to already exist and not scheduled for creation by the current compilation.
/// </summary>
public interface IExistingResource : IResourceNode
{
}
