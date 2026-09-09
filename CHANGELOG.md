# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog 1.1.0](https://keepachangelog.com/en/1.1.0/), and this project follows [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Changed

- Clarified the repository agent contract so daily iteration logs are maintained throughout work and explicitly verified before repository work is declared complete.

## [0.1.1] - 2026-09-09

### Changed

- Aligned repository infrastructure with `InfrastructureIntent/repository-template` `v0.1.0` without changing the public contract surface.
- Replaced legacy automatic Xml2Doc package injection with explicit production-project Xml2Doc intent.
- Brought Architecture Check enforcement forward to the released template baseline.
- Aligned repository agent and Copilot guidance with milestone-driven release and review conventions.
- Set the package baseline to `0.1.1` for the repository-maintenance patch release.

## [0.1.0] - 2026-09-08

### Added

- Initial `InfrastructureIntent.Abstractions` package and solution structure.
- `IntegrationId`, `ResourceType`, `ResourceKey`, and `ResourceIdentity` public identity contracts.
- `IResourceNode`, `IManagedResource`, and `IExistingResource` lifecycle contracts.
- `ResourceReference<TDomain>` for strongly typed, identity-based domain references.
- Focused tests covering identity composition, scoped identity, lifecycle independence, and typed references.
- Apache-2.0 licensing and package metadata.
- Build, Test, Package, and Architecture Check workflow baseline inherited from the InfrastructureIntent repository template.
- Release-documentation workflow for milestone-driven development.
- `TODO.md` as a lightweight repository-facing view of future work.
- `RELEASE_NOTES.md` as the evolving narrative for milestone/release state.
- GitHub Packages publication from version tags during the evolving `0.x` phase.
- Release-tag validation that requires the `vX.Y.Z` tag to match the package version before publication.

### Changed

- Set the initial package version baseline to `0.1.0`.
- Identity component contracts now explicitly reject null, empty, and whitespace values as infrastructure-independent structural invariants.
- Test-project build defaults were corrected so test projects do not inherit production XML documentation requirements.
- .NET 10 test execution was aligned with Microsoft.Testing.Platform/xUnit v3 requirements.

### Fixed

- Removed redundant project-local `Xml2Doc.MSBuild` configuration so Xml2Doc remains centrally managed by repository-wide build configuration.

[Unreleased]: https://github.com/InfrastructureIntent/abstractions/compare/v0.1.1...HEAD
[0.1.1]: https://github.com/InfrastructureIntent/abstractions/releases/tag/v0.1.1
[0.1.0]: https://github.com/InfrastructureIntent/abstractions/releases/tag/v0.1.0
