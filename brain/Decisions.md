# Architecture Decisions

This file records important technical decisions and why they were made.

---

## Decision Template

Date:

Decision:

Reason:

Alternatives Considered:

Impact:

---

# Current Decisions


## Use C# as Primary Backend Language

Date:
2026-07-23

Decision:
All backend systems will primarily use C# and ASP.NET Core.

Reason:
The primary developer has the strongest experience with C#, Visual Studio, and the .NET ecosystem.

Alternatives Considered:
- Node.js
- Python FastAPI
- Java Spring

Impact:
Future AI agents should prioritize .NET solutions unless explicitly instructed otherwise.


---

## Use Clean Architecture Principles

Date:
2026-07-23

Decision:
Applications should separate responsibilities into Domain, Application, Infrastructure, and API layers.

Reason:
Improves maintainability, testing, scalability, and separation of concerns.

Impact:
AI generated code must respect project boundaries.


---

## Use CQRS Pattern

Date:
2026-07-23

Decision:
Commands modify data. Queries retrieve data.

Reason:
Improves organization and scalability.

Impact:
New features should follow command/query separation.


---

## AI Must Understand Existing Code Before Modifying

Date:
2026-07-23

Decision:
AI agents must inspect architecture before making changes.

Reason:
Prevent random code generation and architecture drift.

Impact:
All workflows should begin with analysis.