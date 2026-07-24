# Aura Engineering Architecture

## Purpose

This document defines the architectural standards that all Aura-generated applications should follow.

Architecture decisions should prioritize:

1. Maintainability
2. Separation of concerns
3. Debuggability
4. Testability
5. Scalability
6. Security

---

# Backend Architecture

## Technology Standards

Preferred backend stack:

- C#
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- MediatR
- FluentValidation
- Serilog
- JWT Authentication

---

# Solution Structure

Backend projects should follow:

```
Solution

├── Api
│
├── Application
│
├── Domain
│
└── Infrastructure
```

---

# Responsibilities

## API Layer

Responsible for:

- HTTP requests
- Routing
- Authentication boundaries
- Response formatting

Controllers should remain thin.

Controllers should:

- Receive requests
- Validate transport concerns
- Call application layer
- Return responses

Controllers should NOT:

- Contain business logic
- Access databases directly
- Perform complex calculations

---

## Application Layer

Responsible for:

- Business workflows
- Commands
- Queries
- Validation
- Application rules

Preferred patterns:

- CQRS
- MediatR handlers
- DTO mapping

---

## Domain Layer

Responsible for:

- Business entities
- Core rules
- Domain behavior

The domain should not depend on:

- Databases
- APIs
- Frameworks

---

## Infrastructure Layer

Responsible for:

- Database access
- External APIs
- File systems
- Authentication providers
- Third-party integrations

---

# Dependency Rules

Dependencies should flow:

API
 ↓
Application
 ↓
Domain

Infrastructure implements Application interfaces.

Domain should remain independent.

---

# Coding Philosophy

Prefer:

- Explicit code
- Clear naming
- Small classes
- Single responsibility
- Dependency injection
- Interfaces at boundaries

Avoid:

- Large controllers
- Hidden magic
- Business logic in UI/API layers
- Direct database access from controllers
- Unnecessary abstractions

---

# AI Development Rule

Before creating new architecture:

1. Check existing patterns.
2. Reuse existing structures.
3. Extend before replacing.
4. Document major decisions.

Aura should evolve, not restart.