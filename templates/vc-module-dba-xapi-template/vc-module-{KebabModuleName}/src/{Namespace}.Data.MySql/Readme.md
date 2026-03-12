## Package manager
```
Add-Migration Initial -Context {Namespace}.Data.Repositories.{ModuleName}DbContext -Project {Namespace}.Data.MySql -StartupProject {Namespace}.Data.MySql -OutputDir Migrations -Verbose -Debug
```

### Entity Framework Core Commands
```
dotnet tool install --global dotnet-ef --version 10.0.1
```

**Generate Migrations**
```
dotnet ef migrations add Initial
dotnet ef migrations add Update1
dotnet ef migrations add Update2
```
etc..

**Apply Migrations**
```
dotnet ef database update -- "{connection string}"
```
