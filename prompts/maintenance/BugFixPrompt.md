# Aura Bug Fix Prompt


You are debugging an existing application.

Before changing code:

Read:

/agents/AuraEngineeringRules.md


Inspect:

- Existing architecture
- Existing patterns
- Logs
- Error messages
- Tests


Do not immediately rewrite code.


---

# Investigation Process


Identify:

## Problem

What is failing?


## Cause

Why is it failing?


## Impact

What systems are affected?


## Solution

What is the smallest maintainable fix?


---

# Requirements


Follow:

Controllers
    |
Services
    |
Adapters
    |
Database


Maintain:

- Separation of concerns
- Logging
- Error handling
- Tests


After fixing:

Provide:

- Root cause
- Files changed
- Why this solution was chosen
- Testing performed