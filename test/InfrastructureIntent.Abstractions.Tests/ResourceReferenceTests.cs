using Xunit;

namespace InfrastructureIntent.Abstractions.Tests;

public sealed class ResourceReferenceTests
{
    [Fact]
    public void Same_domain_reference_can_point_to_managed_or_existing_implementations()
    {
        var managed = new ManagedSubnet("network-rg/prod-vnet/app");
        var existing = new ExistingSubnet("network-rg/prod-vnet/app");

        ResourceReference<ISubnet> managedReference = new(managed.Identity);
        ResourceReference<ISubnet> existingReference = new(existing.Identity);

        Assert.Equal(managedReference, existingReference);
        Assert.IsAssignableFrom<ISubnet>(managed);
        Assert.IsAssignableFrom<ISubnet>(existing);
        Assert.IsAssignableFrom<IManagedResource>(managed);
        Assert.IsAssignableFrom<IExistingResource>(existing);
    }

    private interface ISubnet : IResourceNode
    {
    }

    private sealed record ManagedSubnet(string Key) : ISubnet, IManagedResource
    {
        public ResourceIdentity Identity { get; } = new(
            new IntegrationId("azure"),
            new ResourceType("azure.subnet"),
            new ResourceKey(Key));

        public ResourceType Type => Identity.Type;
    }

    private sealed record ExistingSubnet(string Key) : ISubnet, IExistingResource
    {
        public ResourceIdentity Identity { get; } = new(
            new IntegrationId("azure"),
            new ResourceType("azure.subnet"),
            new ResourceKey(Key));

        public ResourceType Type => Identity.Type;
    }
}
