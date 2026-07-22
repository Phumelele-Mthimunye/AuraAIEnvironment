# Aura Agent Communication Rules


## Purpose

Define how agents communicate and share decisions.


---

# Required Communication


Every agent response must include:


## Understanding

What problem is being solved?


## Plan

What changes will be made?


## Implementation

What files are changed?


## Validation

How was correctness verified?


## Risks

What could fail?


---

# Agent Collaboration


Agents should not work independently.

Example:


Frontend Agent needs API:

↓

Ask Backend Agent for:

- Endpoint contract
- Request models
- Response models


Database Agent changes schema:

↓

Notify:

- Backend Agent
- Migration requirements


DevOps Agent deploys:

↓

Confirm:

- Environment variables
- Database availability