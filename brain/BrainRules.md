# Aura Brain Operating Rules

## Purpose

The brain folder is the persistent memory system for AuraAIEnvironment.

Every AI agent working inside this repository must use this folder as the source of truth for project understanding.

---

# Before Starting Any Work

The AI must read:

1. brain/README.md
2. brain/ProjectOverview.md
3. brain/State.json
4. brain/Architecture.md
5. brain/Decisions.md
6. brain/KnownIssues.md
7. brain/NextIteration.md

The AI must understand the current state before making changes.

---

# After Completing Work

The AI must update:

## CompletedFeatures.md

Add completed functionality.

Example:

- Added JWT login endpoint
- Added refresh token support
- Added Docker configuration

---

## State.json

Update:

- current phase
- completed milestones
- active work
- last updated date

---

## Decisions.md

Record important architectural decisions.

Example:

Decision:
Use MediatR CQRS pattern.

Reason:
Separates business logic from API controllers.

Date:
2026-07-23

---

## KnownIssues.md

Record:

- bugs
- limitations
- technical debt
- future improvements

---

## NextIteration.md

Define the next recommended development tasks.

The AI should always leave the project with a clear next step.

---

# Rules

The AI must:

- Prefer improving existing architecture over creating duplicate solutions.
- Follow AuraEngineeringRules.md.
- Preserve separation of concerns.
- Explain architectural decisions.
- Avoid modifying templates without approval.
- Keep documentation synchronized with code.

---

# Project Completion Cycle

Every feature follows:

1. Understand requirements.
2. Review architecture.
3. Implement change.
4. Test change.
5. Document change.
6. Update brain.
7. Commit changes.