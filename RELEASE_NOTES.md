# Release Notes

## 0.1.0 - Initial Abstractions

> Status: Released
>
> Released: 2026-09-08
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

### Package distribution

The released package version is `0.1.0`.

During the evolving `0.x` phase, official InfrastructureIntent packages are published to GitHub Packages only. The package workflow validates every PR and `main` update, while official publication occurs only from a `vX.Y.Z` tag whose version matches the package version.

`v0.1.0` was created from the release commit and successfully published `InfrastructureIntent.Abstractions 0.1.0` to the InfrastructureIntent GitHub Packages NuGet feed.

NuGet.org publication is intentionally excluded from this release and requires a deliberate future stability decision.

### Licensing

`InfrastructureIntent.Abstractions` is licensed under Apache License 2.0. This package is part of the public InfrastructureIntent extension contract surface and is intentionally separate from the controlled/private InfrastructureIntent Engine implementation.

### Release-management baseline

Beginning with this milestone:

- every planned implementation issue belongs to a milestone;
- milestones represent coherent release scope rather than schedules and do not require due dates;
- implementation PRs should correspond to milestone-assigned issues;
- `CHANGELOG.md` records curated notable changes as work lands;
- `TODO.md` is a lightweight repository-facing view, while GitHub Issues/Milestones remain authoritative;
- release notes evolve during the milestone and record the final released state at closeout.

### Release outcome

The `0.1.0` milestone completed the initial public Abstractions contract surface, established deterministic validation and packaging, and proved the GitHub-Packages-only release path required for early InfrastructureIntent development.
