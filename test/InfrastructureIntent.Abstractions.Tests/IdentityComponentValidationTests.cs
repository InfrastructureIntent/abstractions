using Xunit;

namespace InfrastructureIntent.Abstractions.Tests;

internal sealed class IdentityComponentValidationTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void IntegrationIdRejectsMissingValues(string? value)
    {
        Assert.ThrowsAny<ArgumentException>(() => new IntegrationId(value!));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void ResourceTypeRejectsMissingValues(string? value)
    {
        Assert.ThrowsAny<ArgumentException>(() => new ResourceType(value!));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void ResourceKeyRejectsMissingValues(string? value)
    {
        Assert.ThrowsAny<ArgumentException>(() => new ResourceKey(value!));
    }
}
