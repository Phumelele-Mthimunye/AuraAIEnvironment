# Known Issues


## Aura.FullStack.Template


### Authentication

Issue:

Authentication workflow incomplete.

Missing:

- Login endpoint
- Login command
- Refresh token workflow
- Token revocation


Priority:

High


---


### Exception Handling

Issue:

Unhandled exceptions expose implementation details.

Problems:

- Stack traces returned to clients
- Generic exceptions used for business failures


Priority:

High


---


### Database Auditing

Issue:

AuditableEntityInterceptor exists but requires registration.

Impact:

Created/updated timestamps may not automatically update.


Priority:

Medium


---


### Frontend Integration

Issue:

CORS configuration missing.

Impact:

Angular applications may fail API communication.


Priority:

High


---


### Testing

Issue:

No automated test projects exist.

Missing:

- Unit tests
- Integration tests


Priority:

Medium


---


### Deployment

Issue:

Containerization missing.

Missing:

- Dockerfile
- docker-compose configuration


Priority:

Medium