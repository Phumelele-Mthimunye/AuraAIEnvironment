# Aura New Project Creation Prompt


## Mission

Create a complete production-ready application using Aura AI Environment.

You are not only writing code.

You are acting as an AI software engineering team.


---

# Required Context

Before starting:

Read:

/agents/AuraEngineeringRules.md

Then load:

/agents/roles/ArchitectAgent.md

/agents/roles/ProjectManagerAgent.md

Relevant specialist agents:

BackendAgent
FrontendAgent
DatabaseAgent
DevOpsAgent
SecurityAgent


---

# Development Process


## Phase 1 - Requirements

Understand:

- Purpose of application
- Users
- Features
- Business rules
- Security requirements


Create:

docs/Requirements.md


---

# Phase 2 - Architecture


Architect Agent must create:

docs/Architecture.md


Include:

- System overview
- Technology choices
- Database design
- API structure
- Frontend structure
- Deployment strategy


---

# Phase 3 - Database


Database Agent:

Create:

- Entities
- Relationships
- Constraints
- Indexes
- EF Core migrations


Follow:

PostgreSQL
Entity Framework Core


---

# Phase 4 - Backend


Backend Agent:

Use:

C#
ASP.NET Core Web API


Architecture:

Controllers

↓

Services

↓

Adapters

↓

Database


Requirements:

- Dependency injection
- FluentValidation
- Logging
- Error handling
- DTO mapping
- Async programming


---

# Phase 5 - Frontend


Frontend Agent:

Use:

Angular
TypeScript


Requirements:

- Components
- Pages
- Services
- Models
- Guards
- Forms
- API integration


Components must not contain business logic.


---

# Phase 6 - Infrastructure


DevOps Agent:

Create:

- Dockerfile
- docker-compose.yml
- Environment configuration
- Development setup
- Production considerations


Include:

Backend container

Frontend container

Database container


---

# Phase 7 - Security


Security Agent reviews:

- Authentication
- Authorization
- Secrets
- Data exposure
- API security


---

# Phase 8 - Testing


Create:

- Unit tests
- Integration tests
- API tests


Priority:

1. Services
2. Adapters
3. APIs


---

# Completion Requirements


A project is complete only when:

✓ Builds successfully

✓ Database runs

✓ Containers work

✓ APIs documented

✓ Frontend communicates with backend

✓ Errors handled correctly

✓ Logging exists

✓ Documentation updated


---

# Final Output


Provide:

1. Architecture summary

2. Created files

3. Remaining tasks

4. Known limitations

5. Deployment instructions