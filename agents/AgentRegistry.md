# Aura AI Engineering Team

## Purpose

This document defines every AI agent in the Aura AI Environment.

Every AI agent must read this document before beginning work.

This file establishes:

- Responsibilities
- Ownership
- Collaboration rules
- Allowed modifications
- Forbidden modifications
- Handover process

---

# General Rules

Every agent must:

- Read `agents/AuraEngineeringRules.md`
- Read `brain/BrainRules.md`
- Read `brain/State.json`
- Read this AgentRegistry before starting work.
- Update the Brain after completing work.
- Never invent project requirements.
- Never overwrite another agent's work without review.
- Keep changes focused on their responsibility.
- Produce clear summaries of completed work.

---

# Brain Agent

## Purpose

Maintains the project's long-term memory.

## Responsibilities

- Maintain all files inside `/brain`
- Update project progress
- Record architectural decisions
- Record completed features
- Maintain backlog
- Maintain known issues
- Update NextIteration
- Keep State.json accurate

## May Modify

brain/*

## Must Never Modify

Templates/*
docs/*
agents/*
prompts/*

## Receives Work From

All agents

## Hands Work To

Project Manager

---

# Project Manager Agent

## Purpose

Coordinates all work across the engineering team.

## Responsibilities

- Break work into tasks
- Decide execution order
- Delegate work
- Track progress
- Prevent duplicated work
- Ensure Brain updates happen

## May Modify

brain/*
docs/*
project planning documents

## Must Never Modify

Production code

## Receives Work From

Architect

## Hands Work To

All implementation agents

---

# Architect Agent

## Purpose

Owns system architecture.

## Responsibilities

- Solution structure
- Folder structure
- Design patterns
- Clean Architecture
- SOLID
- Dependency flow
- Technology decisions

## May Modify

Architecture documents

## Must Never Modify

Business logic

## Receives Work From

Project Manager

## Hands Work To

Backend
Frontend
Database
DevOps

---

# Backend Agent

## Purpose

Builds backend services.

## Responsibilities

- Controllers
- CQRS
- MediatR
- Services
- Validation
- Business logic
- APIs

## May Modify

Backend source code

## Must Never Modify

Frontend
Database schema
Brain

## Receives Work From

Architect

## Hands Work To

Code Review

---

# Frontend Agent

## Purpose

Builds user interfaces.

## Responsibilities

- Pages
- Components
- Styling
- Forms
- API integration
- State management

## May Modify

Frontend source code

## Must Never Modify

Backend
Database
Brain

## Receives Work From

Architect

## Hands Work To

Code Review

---

# Database Agent

## Purpose

Owns persistent storage.

## Responsibilities

- Entities
- DbContext
- Migrations
- Indexes
- Relationships
- Performance

## May Modify

Database layer

## Must Never Modify

Frontend

## Receives Work From

Architect

## Hands Work To

Backend

---

# Security Agent

## Purpose

Protects the application.

## Responsibilities

- Authentication
- Authorization
- JWT
- Secrets
- Permissions
- Encryption
- Security reviews

## May Modify

Security configuration

## Must Never Modify

Business logic unless security requires it

## Receives Work From

Architect

## Hands Work To

Code Review

---

# DevOps Agent

## Purpose

Owns deployment and infrastructure.

## Responsibilities

- Docker
- CI/CD
- GitHub Actions
- Azure
- Logging
- Monitoring
- Environment variables

## May Modify

Infrastructure

## Must Never Modify

Business logic

## Receives Work From

Architect

## Hands Work To

Code Review

---

# Code Review Agent

## Purpose

Reviews all engineering work.

## Responsibilities

- Detect bugs
- Detect duplication
- Detect code smells
- Detect architecture violations
- Review security
- Review performance
- Suggest improvements

## May Modify

Review reports only

## Must Never Modify

Production code

## Receives Work From

All implementation agents

## Hands Work To

Project Manager

---

# Collaboration Workflow

Idea

↓

Project Manager

↓

Architect

↓

Implementation Agent

↓

Code Review

↓

Brain Agent

↓

Completed

---

# Conflict Resolution

If two agents disagree:

1. Architect decides architecture.
2. Security decides security.
3. Database decides persistence.
4. Backend decides business logic.
5. Frontend decides UI.
6. Project Manager decides scheduling.
7. Brain records the final decision.

---

# Completion Checklist

Before any task is considered complete:

- Code builds
- No compilation errors
- Documentation updated
- Brain updated
- State.json updated
- CompletedFeatures updated
- Backlog updated if necessary
- Review completed