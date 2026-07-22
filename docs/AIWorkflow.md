# Aura AI Development Workflow


## Purpose

Define how AI agents collaborate when creating software.


---

# Agent Hierarchy


## 1. Project Manager Agent

Receives the user request.

Responsible for:

- Understanding goals
- Breaking work into tasks
- Coordinating agents


↓

## 2. Architect Agent

Designs:

- System architecture
- Technology decisions
- Data flow
- Application structure


↓

## 3. Specialist Agents


Backend Agent:

Creates backend systems.


Frontend Agent:

Creates user interfaces.


Database Agent:

Creates data models and persistence.


DevOps Agent:

Creates infrastructure.


Security Agent:

Reviews security.


↓

## 4. Code Review Agent


Reviews all output.

Nothing is considered complete until approved.


---

# Development Principle


AI agents must:

1. Understand before coding
2. Follow existing architecture
3. Prefer maintainable solutions
4. Document decisions
5. Test changes