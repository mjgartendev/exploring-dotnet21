# dotnet CLI Code Scaffolding Tools

## Identity

```sh
# Scaffold /account/register, /account/login, and /account/logout views
# -dc is your application's database context class
dotnet aspnet-codegenerator identity -dc WebApp1.Data.ApplicationDbContext --files "Account.Register;Account.Login;Account.Logout"
```
