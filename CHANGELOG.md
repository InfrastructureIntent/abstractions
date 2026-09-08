# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog 1.1.0](https://keepachangelog.com/en/1.1.0/), and this project follows [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added

- Release-documentation workflow for milestone-driven development.
- `TODO.md` as a lightweight repository-facing view of future work.
- `RELEASE_NOTES.md` as the evolving narrative for the current milestone/release.

## [0.1.0] - Unreleased

### Added

- Initial `InfrastructureIntent.Abstractions` package and solution structure.
- `IntegrationId`, `ResourceType`, `ResourceKey`, and `ResourceIdentity` public identity contracts.
- `IResourceNode`, `IManagedResource`, and `IExistingResource` lifecycle contracts.
- `ResourceReference<TDomain>` for strongly typed, identity-based domain references.
- Focused tests covering identity composition, scoped identity, lifecycle independence, and typed references.
- Apache-2.0 licensing and package metadata.
- Build, Test, Package, and Architecture Check workflow baseline inherited from the InfrastructureIntent repository template.
- GitHub Packages publication from version tags during the evolving `0.x` phase.
- Release-tag validation that requires the `vX.Y.Z` tag to match the package version before publication.

### Changed

- Set the initial package version baseline to `0.1.0`.
- Identity component contracts now explicitly reject null, empty, and whitespace values as infrastructure-independent structural invariants.
- Test-project build defaults were corrected so test projects do not inherit production XML documentation requirements.
- .NET 10 test execution was aligned with Microsoft.Testing.Platform/xUnit v3 requirements.

### Fixed

- Removed redundant project-local `Xml2Doc.MSBuild` configuration so Xml2Doc remains centrally managed by repository-wide build configuration.

Comparison and release links will be added when the initial `v0.1.0` tag exists; the changelog SHALL NOT point at release artifacts that have not yet been created.
