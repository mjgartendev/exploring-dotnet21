# netcoreapp2.1 TodoApi Example

This repository includes a working sample application along with docs for creating a basic Web API using ASP.NET Core 2.1. 

_Features/Examples_

[x] ApiController annotation enhancements
[x] ControllerBase implementation
[x] Swagger Docs Integration
[x] Heavily Commented Default API Controller (ValuesController)
[x] Custom API Controller
[] User Authorization with Identity Framework
[] User Authorization with Auth0

_Frontend_
[x] jQuery/Ajax Frontend
[] Vuejs ClientApp
[] React ClientApp
[] Angular ClientApp
[] Typescript ClientApp
[] Blazor ClientApp

_Hosting_
[] Docker
[] Azure WebApp
[] GCP AppEngine
[] AWS Lightsail
[] Heroku Buildback

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

## Check out the guides for more detailed instructions

> For now, start with "Using the dotnet CLI" then "Adding the Todo Feature"

- [.NET Core Overview](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/dotnetCoreOverview.md)
- [Using the *dotnet new webapi* Template](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/dotnet-new-webapi.md)
- [Using the dotnet CLI](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/dotnetCli.md)
- [Using EF Core CLI Tools](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/efCore.md)
- [Adding the Todos Feature](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/TodoInstructions.md)
- [Adding Identity & Authorization](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/IdentityInstructions.md)
- [Configure Env & AppSettings.json](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/EnvAppSettingsConfig.md)
- [Upgrading to .NET Core 2.1](https://github.com/mjgartendev/exploring-dotnet21/blob/master/docs/dotnetCore2.1.md)
