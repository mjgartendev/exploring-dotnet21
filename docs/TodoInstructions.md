# Adding Todo Functionality

This doc will walk through:

- Creating a simple REST ApiController with full CRUD functionality
- Associating interfaces/models/repositories with a dbContext
- Configuring and Registering the dbContext with a Database service
- Adding comments to improve default Swagger Docs

## Add Model

`/Models/TodoItem.cs`

```cs
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItem
    {
        //props
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        [DefaultValue(false)]
        public bool IsComplete { get; set; }
        public int UserId { get; set; }
        public List<Task> TaskList { get; set; }
    }
}
```

## Add Database Context

`/Models/TodoContext.cs`

```cs
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
```

## Register Database Context

Services (such as TodoContext) are registered with dependency injection during application startup. Components that require these services (such as your MVC/API controllers) are then provided these services via constructor parameters or properties.

In `Startup.cs/ConfigureServices()`:

```cs
// Basic in memory db
services.AddDbContext<TodoContext>(opt =>
                opt.UseInMemoryDatabase("TodoApi"));

// SqlLite (simple, persistent development database)
services.AddDbContext<TodoContext>(opt =>
                opt.UseSqlite("Data Source=TodoApi.db"));

// LocalDb (Specify Db name in appSettings)
services.AddDbContext<TodoContext>(opt =>
                opt.UseSqlServer("DefaultConnection"));

// SqlServer (Specify Host/Username/Password + Db name in appSettings)
services.AddDbContext<TodoContext>(opt =>
                opt.UseSqlServer("SqlServerConnectionString"));

// MongoDb (SQLServerExpress connection string set in appSettings)
    // TODO
```

## Create and Apply Migrations

Once you have a model, you use migrations to create a database.

### Create the Initial Migration

Run `dotnet ef migrations add InitialCreate` to scaffold a migration and create the initial set of tables for the model.

### Apply the Migration to your registered database

Run `dotnet ef database update` to apply the new migration to the database. This command creates the database before applying migrations.

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
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApi V1");
});
```
