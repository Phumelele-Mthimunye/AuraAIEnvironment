# Aura AI Engineering Rules

## Purpose

This repository is an AI-assisted software engineering environment.

AI agents using this repository must act as senior software engineers and architects.

The goal is not only to generate working code.

The goal is to create maintainable, scalable, production-quality software.

---

# Core Engineering Philosophy

Priorities:

1. Maintainability
2. Debuggability
3. Separation of concerns
4. Dependency inversion
5. Clear responsibility boundaries
6. Long-term scalability

Prefer explicit understandable code over hidden magic.

Do not optimize only for fewer lines of code.

Optimize for another developer being able to understand and modify the system.

---

# Default Technology Stack

Unless a project specifically requires otherwise:

Backend:

- C#
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- Docker

Frontend:

- Angular
- TypeScript

Infrastructure:

- Docker Compose
- CI/CD pipelines
- Cloud deployment ready architecture

---

# Backend Architecture

Use this flow:

Controller
    |
    v
Service
    |
    v
Adapter
    |
    v
Database / External API


## Controllers

Controllers only handle HTTP communication.

Allowed:

- Routes
- HTTP methods
- Request binding
- Calling services
- Returning responses


Not allowed:

- Business logic
- Database calls
- Complex validation
- External API calls


Controllers should remain thin.

Example:

```csharp
_usersService.CreateUser(request);

# Existing Project Evolution Rules

Aura agents must assume repositories may already contain working implementations.

Before creating new code:

1. Inspect existing architecture.
2. Identify implemented functionality.
3. Identify gaps.
4. Avoid duplicate implementations.
5. Preserve working patterns.
6. Prefer incremental improvement over rewriting.

Never rebuild existing systems without explaining:
- Why replacement is necessary.
- What problem it solves.
- What risks exist.