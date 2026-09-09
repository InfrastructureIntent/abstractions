# Release Notes

## 0.1.1 - Repository Baseline Alignment

> Status: Released
>
> Released: 2026-09-09
>
> Milestone: `0.1.1 - Repository Baseline Alignment`
>
> Distribution: GitHub Packages only during the evolving `0.x` phase. NuGet.org publication remains intentionally deferred.

### Summary

Align `InfrastructureIntent.Abstractions` with the finalized `InfrastructureIntent/repository-template` `v0.1.0` repository baseline without changing the public contract surface released in `0.1.0`.

This patch release is repository maintenance only.

### Included work

- Replaced legacy automatic Xml2Doc package injection with explicit production-project Xml2Doc intent.
- Brought Architecture Check forward to the finalized template enforcement baseline applicable to Abstractions.
- Aligned repository-local agent and Copilot guidance with the finalized milestone/review conventions.
- Preserved the existing .NET 10 / Microsoft.Testing.Platform-compatible xUnit v3 package baseline.
- Set package version to `0.1.1` for patch-release validation and publication.

### Compatibility

No public `InfrastructureIntent.Abstractions` contracts were added, removed, or changed by this milestone. PR #13 changed repository/build/documentation files plus the production project file only; no public contract source files were modified. The `0.1.0` contract generation therefore remains unchanged.

### Validation

PR #13 completed with the required validation on its final head:

- Build: passed.
- Test: passed.
- Package: passed.
- Architecture Check: passed.
- Copilot/review findings: actioned and resolved.
- Public API surface: unchanged from `0.1.0` based on the merged changed-file set and absence of contract source changes.

### Distribution / publication

The release remains GitHub-Packages-only during the evolving `0.x` phase. NuGet.org publication is intentionally excluded.

The `v0.1.1` tag is the publication trigger and must point at the final release-closeout commit with package version `0.1.1`.

### Release outcome

The `0.1.1` milestone completes the repository-baseline alignment needed before Engine begins consuming Abstractions. The repository now conforms to the released InfrastructureIntent template baseline while preserving the public `0.1.0` contract generation unchanged.
