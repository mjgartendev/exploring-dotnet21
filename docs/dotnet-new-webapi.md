# dotnet new webapi template overview

## Template Options

## Files

### Program.cs

This is the entry point for your web app. The main method calls the web host builder, which essentially starts a console application to host the process your app run inside.

All of your app code is contained within this process, and interaction with web servers or host OS functionality is managed with integrations built into the web host builder (e.g., `UseIISIntegration()`)

The Web Host Builder will call your Startup class in order to configure the web host with injected services and environment variables necessary for you app to run.

- Default web host builder options are almost always what you want for simple projects.

- Mainly used for integrating with reverse proxy web servers (IIS, ngnix, Apache)

- Can also inject services useful during app startup (e.g., logging issues with app or db creation before successful startup)

### Startup.cs

This class is used by the web host builder during the initial startup in order to configure your app's environment and services.

Your appSettings.json + appSettings.{{currentEnvironment}}.json files are used, along with default values and built-in methods.

#### `Configure()`

#### `ConfigureServices()`

### appSettings.{{environment}}.json

The appSettings.json files work a bit like CSS - the base file values will be used unless that key is overridden in a specific environment's appSettings.

Your appSettings.json file is the base

### {{appName}}.csproj

## Folders

### Controllers

Same as ASP.NET Framework Controllers with a few changes

- WebApi & MVC controllers both use the MVC library in dotnet core
- ApiController annotation provides some handy defaults
- ApiControllers inheriting from ControllerBase have a significantly smaller footprint than an ASP.NET Framework MVC Web App

### Models

Same as ASP.NET Framework Models

### wwwroot

This folder holds compiled & static files needed for your app to run in a browser

### obj & bin

Ignore these until you need to troubleshoot.

These should NOT be checked into source control

## Restore & Run

## Build & Publish

[Free Azure Account](https://azure.microsoft.com/en-us/free/?ref=microsoft.com&utm_source=microsoft.com&utm_medium=docs&utm_campaign=v)
