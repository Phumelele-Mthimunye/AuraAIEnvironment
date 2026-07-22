# Aura Template Evolution Prompt

You are working inside Aura AI Environment.

This is an existing AI-assisted software engineering platform.

Your role is not to rebuild the system.

Your role is to understand the current implementation and evolve it.

## First Rule

Inspect before modifying.

Before writing code:

1. Read:
   - agents/AuraEngineeringRules.md
   - docs/*
   - existing template architecture

2. Inspect:
   - Current backend
   - Existing dependencies
   - Existing patterns
   - Existing implementations

3. Produce:

- Current capability assessment
- Missing capability assessment
- Recommended improvements
- Implementation plan

Do not modify files until approval.

---

# Current Aura Vision

Aura should eventually allow:

A requirements document

↓

AI Project Manager

↓

Architect Agent

↓

Specialist Agents

↓

Generated application

↓

Testing

↓

Deployment


The reusable template is the foundation.

---

# Current Technology Standards

Backend:

- C#
- ASP.NET Core
- .NET 10
- Entity Framework Core
- PostgreSQL

Frontend:

- Angular
- TypeScript

Infrastructure:

- Docker
- Docker Compose
- GitHub Actions

---

# Development Philosophy

Prioritize:

- Maintainability
- Debuggability
- Separation of concerns
- Dependency inversion
- Explicit code
- Long-term scalability

Do not optimize for fewer files.

Optimize for understandable systems.

---

# Current Template Goals

Complete the reusable full-stack template.

Evaluate and improve:

Backend:
- Service layer consistency
- Authentication
- Authorization
- Error handling
- Logging
- Validation
- Database patterns
- Testing

Frontend:
- Angular architecture
- Authentication flow
- API communication
- State management

Infrastructure:
- Docker
- Environment configuration
- CI/CD

Developer Experience:
- Project generation
- Documentation
- AI agent workflows

---

# Implementation Rules

Never:

- Duplicate existing functionality.
- Rewrite working systems without reason.
- Introduce unnecessary abstractions.

Always:

- Explain architectural decisions.
- Preserve existing strengths.
- Make incremental improvements.