# Exploring .NET Core

## Overview

### Benefits

ASP.NET Core provides the following benefits:

- A unified story for building web UI and web APIs.
- A cloud-ready, environment-based configuration system.
- Integration of modern, client-side frameworks and development workflows.
- Built-in dependency injection.
- A lightweight, high-performance, and modular HTTP request pipeline.
- Ability to host on IIS, Nginx, Apache, Docker, or self-host in your own process.
- Side-by-side app versioning when targeting .NET Core.
- Tooling that simplifies modern web development.
- Ability to build and run on Windows, macOS, and Linux.
- Open-source and community-focused.
- ASP.NET Core ships entirely as NuGet packages. Using NuGet packages allows you to optimize your app to include only the necessary dependencies. In fact, ASP.NET Core 2.x apps targeting .NET Core only require a single NuGet package. The benefits of a smaller app surface area include tighter security, reduced servicing, and improved performance.

### Reasons for a new .NET

#### .NET Framework Limitations

#### Rise of Cloud Environments

#### Evolution of Frontend Web App Frameworks

## Tools

### dotnet SDK/CLI

The dotnet CLI makes developing with .NET Core extremely flexible and easier to document.

Package management has been improved and cross-platform development outside of Visual Studio/Windows works well

### EF Core

- Included with SDK, powerful integration with dotnet CLI
- Includes most features from full featured Entity Framework with much less overhead
- May need to update `.csproj` to ensure design tools and codegeneration packages are included

### VS Code + Extensions

VS Code is an open-source, cross-platform IDE designed to be a lightweight and modern alternative to Visual Studio.

- Integrated Terminal works extremely well with dotnet CLI
- Frontend App Development is more intuitive and efficient, especially when configured to launch a Git Bash terminal using the Windows Subsystem for Linux
- The open source engine powering VS Code is being used in several Cloud IDE solutions allowing a wide range of flexibility where you choose to code your .NET Core projects

### SQL Server Express - LocalDb

When used with appSettings.json "DefaultConnection" string, code-first Migrations, and Database Service dependency injection it becomes trivial to share and deploy code that depends on a persistent database.

- Just clone a repo, restore packages, and run
- Migrations will automatically be applied to the Database specified in the LocalDb connection string
- If the specified Database doesn't exist yet on the connected server, it will be created & seeded with data automatically

### Azure: WebApps, ARM Templates and CLI

- Azure's Free Tier allows you to host demos or personal projects built with ASP.NET Core easily.
- Publish Profiles can easily be configured to create & connect to a SQL Database when deploying
- Azure Resource Manager templates allows you to configure your entire deployment process in code and simply reuse for similar projects in the future

### Azure CosmosDb Local Emulator

- Works with NoSql, Sql or Graph databases
- Makes local development much easier
- Uses similar Database as production so deployments are more predictable
