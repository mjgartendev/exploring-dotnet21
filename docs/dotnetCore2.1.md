# Using netcoreapp2.1 Features

## Installing

- SDK
- Runtime

## Project Settings

### csproj

- make sure latest version is specified for AspNetCore.App PackageReference:
  `<PackageReference Include="Microsoft.AspNetCore.App" Version="2.1.2" />`

> CLI and codegen tooling packages may need updated as well

### Startup

- Set the compatability setting on `services.AddMvc()` in the Configure method

### Controllers

- inherit from ControllerBase instead of Controller
- add `[ApiController]` annotation to the entire class

## Features

### ApiController && ControllerBase

- Automatic Model Validation
- ActionResult Updates
- Swagger Integration

### Identity UI
