# netcoreapp2.1 TodoApi Example

This repository includes a working sample application along with docs for creating a basic Web API using ASP.NET Core 2.1.

## Features/Examples

### dotnet core

- [x] Heavily Commented ValuesController (default webapi controller)
- [x] TodoApi Controller
- [x] Swagger Docs Integration
- [x] (new in v2.1) ApiController annotation implementation
- [x] (new in v2.1) ControllerBase implementation
- [ ] Sql Database Integration (SqlServer/Azure SQL DB)
- [ ] Auth & Identity Configuration
- [ ] Logging & Monitoring Examples
- [ ] Testing & CI/CD Configuration Examples

### Auth & Identity

- [ ] User Auth with Identity Framework
- [ ] User Auth with Auth0
- [ ] User Auth with Okta

### Frontend

- [ ] ASP.NET MVC Views
- [ ] Razor Pages
- [x] Simple jQuery/Ajax Frontend
- [ ] Typescript ClientApp
- [ ] Vuejs ClientApp
- [ ] React ClientApp
- [ ] Angular ClientApp
- [ ] Blazor ClientApp

### Hosting

- [ ] Docker
- [ ] Azure WebApp
- [ ] GCP AppEngine
- [ ] AWS Lightsail
- [ ] Heroku Buildback

## Quick Start

Install the following:

- [.NET Core 2.1 SDK or later](https://www.microsoft.com/net/download/all)

Then open a terminal and run:

- `git clone https://github.com/mjgartendev/exploring-dotnet21.git TodoApi`
- `cd TodoApi`
- `dotnet restore`
- `dotnet run`

Open browser to

- API Frontend: https://localhost:5001/api/values
- ClientApp: https://localhost:5001/
- Swagger Docs UI: https://localhost:5001/swagger

> May need to trust the dev cert to use https:

```console
# Run the following to see available options
dotnet dev-certs https --help
```

## Docs & Tutorials

> For now, start with "Using the dotnet CLI" then "Adding the Todo Feature"

### Overview Docs

- [.NET Core Overview](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/dotnetCoreOverview.md)
- [`dotnet new webapi` Template Overview](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/dotnet-new-webapi.md)
- [Version 2.1 New Features](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/dotnetCore2.1.md)

### Get Familiar With New Tools

- [Using the dotnet CLI](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/dotnetCli.md)
- [Using EF Core CLI Tools](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/efCore.md)
- [dotnet codegenerator (aka EF Scaffolding)](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/aspnet-codegenerator.md)

### Getting Started Tutorials

- [Adding the Todos Feature](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/TodoInstructions.md)
- [Adding Identity & Authorization](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/IdentityInstructions.md)
- [Configure Env & AppSettings.json](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/EnvAppSettingsConfig.md)
- [Deploying WebApp + Database](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/dotnetCoreDeploymentWalkthrough.md)
