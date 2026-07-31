# Aura AI Engineering Workflow

## Purpose

This document defines the standard workflow every AI agent must follow.

Every task, regardless of size, follows this process.

---

# Phase 1 — Understand

Every agent must first read:

- agents/AuraEngineeringRules.md
- agents/AgentRegistry.md
- brain/BrainRules.md
- brain/State.json
- brain/ProjectOverview.md

The agent must understand:

- Current project goals
- Current iteration
- Existing architecture
- Previous decisions
- Outstanding issues

No coding begins until context is understood.

---

# Phase 2 — Plan

Before writing code, the responsible agent must:

- Understand the requested feature
- Check whether it already exists
- Check architecture compatibility
- Check coding standards
- Estimate affected files

If architecture changes are required:

Architect Agent must approve first.

---

# Phase 3 — Build

Implementation agents:

- Make small focused changes.
- Never perform unrelated refactoring.
- Follow SOLID principles.
- Follow Clean Architecture.
- Keep code readable.
- Prefer explicit code over clever code.

---

# Phase 4 — Self Review

Before handing work over:

- Build project
- Check for compilation errors
- Review own code
- Remove duplication
- Verify naming
- Verify architecture

Only then continue.

---

# Phase 5 — Code Review

Code Review Agent verifies:

- Code quality
- Security
- Architecture
- Performance
- Readability
- Maintainability
- Consistency

If rejected:

Return to implementation.

---

# Phase 6 — Update Brain

Brain Agent updates:

- CompletedFeatures.md
- Backlog.md
- Decisions.md
- KnownIssues.md
- NextIteration.md
- ProjectMap.md
- State.json

This keeps project memory accurate.

---

# Phase 7 — Complete

Project Manager verifies:

- Feature complete
- Documentation complete
- Brain updated
- Tests passing
- Ready for next iteration

Only then is work marked complete.

---

# Emergency Rules

If an AI is uncertain:

STOP.

Read the Brain again.

Do not guess.

If information is missing:

Record it as an assumption.

---

# Golden Rule

Every completed task leaves the project in a better state than before.

Every AI is responsible for improving—not degrading—the project.