# TODO

This file provides a lightweight repository-facing view of known future work for `InfrastructureIntent.Abstractions`.

GitHub Issues and Milestones are the authoritative planning system. Items listed here should either correspond to an existing issue/milestone or remain clearly marked as a candidate until promoted into planned work.

## Current milestone: 0.1.0 - Initial Abstractions

- Complete the validation, CI, package, and GitHub Packages publication baseline tracked by issue #6.
- Complete release documentation and milestone closeout tracked by issue #7.

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
