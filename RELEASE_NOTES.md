# Release Notes

## 0.1.1 - Repository Baseline Alignment

> Status: In progress
>
> Milestone: `0.1.1 - Repository Baseline Alignment`
>
> Distribution: GitHub Packages only during the evolving `0.x` phase. NuGet.org publication remains intentionally deferred.

### Summary

Align `InfrastructureIntent.Abstractions` with the finalized `InfrastructureIntent/repository-template` `v0.1.0` repository baseline without changing the public contract surface released in `0.1.0`.

This patch release is repository maintenance only.

### Included work

- Replace legacy automatic Xml2Doc package injection with explicit production-project Xml2Doc intent.
- Bring Architecture Check forward to the finalized template enforcement baseline applicable to Abstractions.
- Align repository-local agent and Copilot guidance with the finalized milestone/review conventions.
- Preserve the existing .NET 10 / Microsoft.Testing.Platform-compatible xUnit v3 package baseline.
- Set package version to `0.1.1` for patch-release validation.

### Compatibility

No public InfrastructureIntent.Abstractions contracts are added, removed, or changed by this milestone. The `0.1.0` contract generation remains unchanged.

### Validation

Before release closeout require:

- Build: pending.
- Test: pending.
- Package: pending.
- Architecture Check: pending.
- Copilot/review findings: action or explicit disposition required.
- Public API surface: confirmation required against `0.1.0`.

Final release evidence will be recorded only after the maintenance PR is merged and the closeout state is known.

### Remaining work before closeout

- Merge issue #12 after validation and review.
- Tag `v0.1.1` only after release documentation reflects the final merged state.
