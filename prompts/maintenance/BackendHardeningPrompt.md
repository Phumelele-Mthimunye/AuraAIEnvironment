# Aura Backend Hardening Prompt


You are improving the Aura.FullStack.Template backend.

Before changing code:

Read:

- agents/AuraEngineeringRules.md
- docs/Architecture.md
- docs/DevelopmentLifecycle.md
- docs/backend_completion_audit.md


Goal:

Transform the existing .NET 10 backend template into a production-ready baseline.

Important:

DO NOT rebuild existing architecture.

Preserve:

- Clean Architecture
- MediatR CQRS
- EF Core 10
- PostgreSQL
- JWT authentication
- Adapter pattern
- Existing folder structure


Implement improvements in phases.


## Phase 1 - Security and Reliability


Fix:

1. ExceptionHandlingMiddleware

Requirements:

- Never expose stack traces in production
- Use ProblemDetails style responses
- Support known application exceptions


2. Register AuditableEntityInterceptor

Ensure:

- CreatedAt updates automatically
- UpdatedAt updates automatically


3. Add CORS configuration

Prepare for Angular frontend.


## Phase 2 - Authentication Completion


Implement:

- Login endpoint
- Login command
- Login handler
- Refresh token endpoint
- Logout/revoke token endpoint


Maintain:

- JWT access tokens
- Refresh token database entity
- Existing password hashing


## Phase 3 - API Quality


Implement:

- Standard API response handling
- Domain exceptions:

Examples:

NotFoundException
ConflictException
ForbiddenException


Avoid:

throw new Exception()


## Phase 4 - Configuration


Ensure:

appsettings.json contains safe defaults for:

- ConnectionStrings
- Jwt configuration


Secrets must remain environment based.


## Rules

After each phase:

Run:

dotnet build

Do not continue if build fails.

Explain:

- files changed
- architectural reasoning
- possible risks


Do not modify frontend, Docker, or deployment yet.