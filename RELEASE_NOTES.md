# Release Notes

## 0.1.0 - Initial Abstractions

> Status: In progress
>
> Milestone: `0.1.0 - Initial Abstractions`
>
> Distribution: GitHub Packages only during the evolving `0.x` phase. NuGet.org publication is intentionally deferred until the public contracts reach an explicit stability milestone.

`0.1.0` establishes the first public InfrastructureIntent contract package and the baseline required for the private Engine and future public ecosystem components to share stable structural types without depending on Engine implementation code.

### Initial public contracts

The release introduces canonical resource identity through:

- `IntegrationId`
- `ResourceType`
- `ResourceKey`
- `ResourceIdentity`

Each identity component is a structural contract value and must be non-null, non-empty, and non-whitespace. Infrastructure-specific naming, formatting, scoping, and canonicalization remain the responsibility of the owning Integration.

The release also introduces the initial graph-participant lifecycle contracts:

- `IResourceNode`
- `IManagedResource`
- `IExistingResource`

Domain semantic type and lifecycle remain orthogonal. Existing and managed resources participate in the same identity model without forcing Engine implementation details into the public package.

`ResourceReference<TDomain>` provides the first typed, identity-based reference contract. References target domain semantic contracts rather than managed/existing implementation types and do not themselves imply relationships or prerequisite dependencies.

### Engineering baseline

The repository was created from the InfrastructureIntent C# repository template and proved the standard root solution, `src/`, and `test/` structure against a real public package.

The initial work also validated the standard Build, Test, Package, and Architecture Check workflows and surfaced template defects that were corrected at the template source, including test-project XML documentation behavior and .NET 10 Microsoft.Testing.Platform configuration.

### Licensing

`InfrastructureIntent.Abstractions` is licensed under Apache License 2.0. This package is part of the public InfrastructureIntent extension contract surface and is intentionally separate from the controlled/private InfrastructureIntent Engine implementation.

### Release-management baseline

Beginning with this milestone:

- every planned implementation issue belongs to a milestone;
- milestones represent coherent release scope rather than schedules and do not require due dates;
- implementation PRs should correspond to milestone-assigned issues;
- `CHANGELOG.md` records curated notable changes as work lands;
- `TODO.md` is a lightweight repository-facing view, while GitHub Issues/Milestones remain authoritative;
- this file evolves during the milestone and can seed the GitHub Release description at milestone close.

### Remaining work before 0.1.0 closeout

- Complete issue #6: validation, CI, package, and GitHub Packages publication baseline.
- Complete issue #7: release documentation and milestone closeout.
