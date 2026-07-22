# Aura Deployment Prompt


## Mission

Prepare an application for deployment using production engineering practices.


---

# Required Agents


Load:

DevOpsAgent

SecurityAgent

DatabaseAgent


---

# Infrastructure Review


Check:

- Docker configuration
- Environment variables
- Database configuration
- Secrets management
- Networking


---

# Docker Requirements


Applications should include:


Backend:

- Dockerfile
- Production configuration


Frontend:

- Dockerfile
- Build optimization


Database:

- PostgreSQL container
- Persistent storage


---

# Environment Rules


Never commit:

- API keys
- Passwords
- Connection strings


Use:

- Environment variables
- Secret managers
- Deployment configuration


---

# Database Deployment


Verify:

- Migration strategy
- Backup strategy
- Connection security


---

# Security


Review:

- HTTPS
- Authentication
- Authorization
- Container security


---

# Final Report


Provide:

Deployment architecture

Required infrastructure

Environment variables

Deployment steps

Known risks