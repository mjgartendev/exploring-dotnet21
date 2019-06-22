# Entity Framework Core Overview

## dotnet Cli Commands

```bash
# Usage
dotnet ef [cmd]

## [cmds]
    database    # commands to manage the database
    dbcontext   # commands to manage DbContext types
    migrations  # commands to manage migrations
```

> Use `dotnet ef [cmd] --help` for more information about a cmd.

---

### DbContext

commands to manage DbContext types.

Your ApplicationDbContext ineherits from a base DbContext class. This class connects your Entity Models & Database Services.

#### Code Snippet: DbContext

```bash
# Usage:
dotnet ef dbcontext [opts] [cmd]

## [opts]
    --help           # Show help information
    --verbose        # Show verbose output.
    --no-color       # Do not colorize output.
    --prefix-output  # Prefix output with level.

## [cmds]
    info [opts]              # Gets information about a DbContext type
    list [opts]              # Lists available DbContext types
    scaffold [args] [opts]   # Scaffolds a DbContext and entity types for a database

    ### dbcontext {cmd} [opts]
        --json                                 # Show JSON output.
        -p|--project <PROJECT>                 # The project to use.
        -s|--startup-project <PROJECT>         # The startup project to use.
        --framework <FRAMEWORK>                # The target framework.
        --configuration <CONFIGURATION>        # The configuration to use.
        --runtime <RUNTIME_IDENTIFIER>         # The runtime to use.
        --msbuildprojectextensionspath <PATH>  # The MSBuild project extensions path. Defaults to "obj".
        --no-build                             # Don't build the project. Only use this when the build is up-to-date.
        -h|--help                              # Show help information
        -v|--verbose                           # Show verbose output.
        --no-color                             # Don't colorize output.
        --prefix-output                        # Prefix output with level.

    ### dbcontext scaffold [args]
        <CONNECTION>               # The connection string to the database.
        <PROVIDER>                 # The provider to use. (E.g. Microsoft.EntityFrameworkCore.SqlServer)

    ### dbcontext scaffold [opts]
        -d|--data-annotations          # Use attributes to configure the model (where possible). If omitted, only the fluent API is used.
        -c|--context <NAME>            # The name of the DbContext.
        --context-dir <PATH>           # The directory to put DbContext file in. Paths are relative to the project directory.
        -f|--force                     # Overwrite existing files.
        -o|--output-dir <PATH>         # The directory to put files in. Paths are relative to the project directory.
        --schema <SCHEMA_NAME>         # The schemas of tables to generate entity types for.
        -t|--table <TABLE_NAME>        # The tables to generate entity types for.
        --use-database-names           # Use table and column names directly from the database.
```

---

### Migrations

Commands to manage migrations. Use migrations to update a database with changes to a DbContext

#### Code Snippet: Migrations

```bash
# Usage:
dotnet ef migrations [opts] [cmd]

## [opts]
    --help           # Show help information
    --verbose        # Show verbose output.
    --no-color       # Don't colorize output.
    --prefix-output  # Prefix output with level.

## [cmds]
    add          # Adds a new migration.
    list         # Lists available migrations.
    remove       # Removes the last migration.
    script       # Generates a SQL script from migrations.
```

> Use `dotnet ef migrations [cmd] --help` for more information about a cmd.

---

### Database

Commands to manage the database.

#### Code Snippet: Database

```bash
# Usage
dotnet ef database [opts] [cmd]

## [opts]
    --help          # Show help information
    --verbose       # Show verbose output.
    --no-color      # Do not colorize output.
    --prefix-output # Prefix output with level.

## [cmds]
    drop            # Drops the database.
    update          # Updates the database to a specified migration.
```

> Use `dotnet ef database [cmd] --help` for more information about a cmd.

---

## EF Core: Code First

### Create Entity Models

### Create a DbContext

### Register a DbContext

Services (such as TodoContext) are registered with dependency injection during application startup. Components that require these services (such as your MVC/API controllers) are then provided these services via constructor parameters or properties.

### Create and Apply Migrations

Create a migration from the current DbContext

`dotnet ef migrations add InitialMigration`

Update the Database Tables with new Migration script

`dotnet ef database update InitialMigration`

### Steps for making changes to existing Entity Models && DbContext

- Change existing Model or Add new Model
- Update DbContext as needed
- Create a Migration reflecting updates to DbContext
- Use Migration to Update Database tables/schema
- Push code changes (including latest Migration, these can be rolled back) to source control
- Ensure migrations are applied to databases in staging && production environments

## EF Core: DB First

```bash
dotnet ef dbcontext scaffold <CONNECTION> <PROVIDER>

# CONNECTION = Connection String to existing database
# PROVIDER = .NET Data Access Class for Database Provider (e.g., Microsoft.EntityFrameworkCore.SqlServer)
```
