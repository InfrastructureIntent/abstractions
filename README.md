# InfrastructureIntent.Abstractions

Public contracts for the InfrastructureIntent ecosystem.

This repository defines the minimal contracts required for InfrastructureIntent Engine and independently developed Adapters, Integrations, Backends, Targets, and conformance tooling to communicate without depending on the private Engine implementation.

## Architectural boundary

This repository contains contracts only. It does **not** contain graph algorithms, reference-resolution implementations, cycle detection, compiler orchestration, Target lowering, or infrastructure-domain semantics.

The canonical architecture and ADRs live in the public `InfrastructureIntent/documentation` repository.

## Initial contract surface

The first contract generation establishes:

- `IntegrationId`
- `ResourceType`
- `ResourceKey`
- `ResourceIdentity`
- `IResourceNode`
- `IManagedResource`
- `IExistingResource`
- `ResourceReference<TDomain>`

Domain type and lifecycle are orthogonal. A domain contract such as `ISubnet : IResourceNode` may be implemented by either an `IManagedResource` or `IExistingResource`, and `ResourceReference<ISubnet>` targets the domain contract rather than a lifecycle-specific implementation.

## Repository layout

```text
InfrastructureIntent.Abstractions.sln
src/
  InfrastructureIntent.Abstractions/
test/
  InfrastructureIntent.Abstractions.Tests/
```

## Build

```bash
dotnet restore InfrastructureIntent.Abstractions.sln
dotnet build InfrastructureIntent.Abstractions.sln -c Release --no-restore
dotnet test InfrastructureIntent.Abstractions.sln -c Release --no-build
dotnet pack InfrastructureIntent.Abstractions.sln -c Release --no-build -o artifacts
```

## Release management

Planned implementation work is tracked through GitHub Issues assigned to a release milestone. Milestones represent coherent release scope rather than schedules and do not require due dates.

- [`CHANGELOG.md`](CHANGELOG.md) records curated notable changes and follows Keep a Changelog 1.1.0.
- [`TODO.md`](TODO.md) provides a lightweight view of candidate/future work; GitHub Issues and Milestones remain authoritative.
- [`RELEASE_NOTES.md`](RELEASE_NOTES.md) is the evolving human-readable narrative for the current milestone and can seed the GitHub Release description at closeout.

During the evolving `0.x` phase, packages are intended for GitHub Packages only. NuGet.org publication is deferred until the public contract surface reaches an explicit stability milestone.

## Versioning

Public contract compatibility follows the contract-generation model documented by InfrastructureIntent ADR-007. Package versions and contract generations are related but are not assumed to be identical concepts.

## License

Licensed under the Apache License 2.0. See `LICENSE`.
