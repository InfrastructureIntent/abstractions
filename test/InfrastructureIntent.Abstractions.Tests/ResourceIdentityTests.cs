using Xunit;

namespace InfrastructureIntent.Abstractions.Tests;

public sealed class ResourceIdentityTests
{
    [Fact]
    public void Equal_components_produce_equal_identity()
    {
        var left = new ResourceIdentity(
            new IntegrationId("azure"),
            new ResourceType("azure.subnet"),
            new ResourceKey("network-rg/prod-vnet/app"));

        var right = new ResourceIdentity(
            new IntegrationId("azure"),
            new ResourceType("azure.subnet"),
            new ResourceKey("network-rg/prod-vnet/app"));

        Assert.Equal(left, right);
        Assert.Equal(left.GetHashCode(), right.GetHashCode());
    }

    [Fact]
    public void Scope_encoded_by_integration_distinguishes_same_logical_name()
    {
        var east = new ResourceIdentity(
            new IntegrationId("azure"),
            new ResourceType("azure.subnet"),
            new ResourceKey("network-east-rg/east-vnet/app"));

        var west = new ResourceIdentity(
            new IntegrationId("azure"),
            new ResourceType("azure.subnet"),
            new ResourceKey("network-west-rg/west-vnet/app"));

        Assert.NotEqual(east, west);
    }

    [Fact]
    public void Resource_type_participates_in_identity()
    {
        var nic = new ResourceIdentity(
            new IntegrationId("azure"),
            new ResourceType("azure.network-interface"),
            new ResourceKey("prod-rg/web-01"));

        var disk = new ResourceIdentity(
            new IntegrationId("azure"),
            new ResourceType("azure.managed-disk"),
            new ResourceKey("prod-rg/web-01"));

        Assert.NotEqual(nic, disk);
    }
}
