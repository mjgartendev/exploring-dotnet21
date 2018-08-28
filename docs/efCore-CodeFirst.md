# Entity Framework Core Overview

## `dotnet ef` commands

```sh
# Create Migration from DbContext
dotnet ef migrations add InitialCreate

# Apply Migration to registered Database
dotnet ef database update
```

## EF Core: Code First

### Create Entity Models

### Create a DbContext

### Register a DbContext

Services (such as TodoContext) are registered with dependency injection during application startup. Components that require these services (such as your MVC/API controllers) are then provided these services via constructor parameters or properties.

### Create and Apply Migrations

### Scaffolding Commands

### Adding/Updating Models

- Make changes to model
- Update DbContext
- Create new migration
- Apply migrations
- Push code changes

## EF Core: DB First
