# TODO

This file provides a lightweight repository-facing view of known future work for `InfrastructureIntent.Abstractions`.

GitHub Issues and Milestones are the authoritative planning system. Items listed here should either correspond to an existing issue/milestone or remain clearly marked as a candidate until promoted into planned work.

## Released baseline

`0.1.1 - Repository Baseline Alignment` was completed on 2026-09-09 as a repository-maintenance patch release. It aligned Abstractions with `InfrastructureIntent/repository-template` `v0.1.0` without changing the public contract surface established in `0.1.0`.

`0.1.0 - Initial Abstractions` was released on 2026-09-08 and published to GitHub Packages as `InfrastructureIntent.Abstractions 0.1.0`.

There is no active Abstractions implementation milestone after `0.1.1`. New implementation work must first be assigned to a new milestone and represented by a GitHub issue before code changes begin.

## Candidate future work

The following items are architectural candidates, not committed release scope. They must be represented by milestone-assigned GitHub issues before implementation begins.

- Resource Graph public lookup/traversal contracts if required by Engine implementation.
- Relationship and dependency structural contracts if Engine implementation proves they belong in public Abstractions.
- Domain-contract-to-`ResourceType` association metadata.
- Common diagnostic contracts spanning Integration, Engine, Backend, and Target boundaries.
- Compilation-context contracts if a public cross-component surface is required.
- Contract-generation/version compatibility metadata.
- Public conformance contracts/tooling required by third-party Integrations, Backends, or Targets.

## Process rule

Do not implement an item from this file directly. First create or select an appropriate release milestone, create an issue describing the intended work, assign the issue to that milestone, and then implement through a linked pull request.
