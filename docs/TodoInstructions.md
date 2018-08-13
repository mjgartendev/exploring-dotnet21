# Adding Todo Functionality

## Add Model

`/Models/TodoItem.cs`

## Add Database Context

`/Models/TodoContext.cs`

## Register Database Context

`Startup.cs/ConfigureServices()`

```cs
// Basic in memory db
services.AddDbContext<TodoContext>(opt =>
                opt.UseInMemoryDatabase("TodoList"));

// LocalDb (SQLServerExpress connection string set in appSettings)

// SqlServer (SQLServerExpress connection string set in appSettings)

// MongoDb (SQLServerExpress connection string set in appSettings)
```

## Create Migrations

## Apply Migrations

## Configure Swagger

Startup.ConfigureServices()

```cs
// Register the Swagger generator, defining 1 or more Swagger documents
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Info { Title = "Todo API", Version = "v1" });
});
```

Startup.Configure()

```cs
// Enable middleware to serve generated Swagger as a JSON endpoint.
app.UseSwagger();

// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
// specifying the Swagger JSON endpoint.
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});
```
