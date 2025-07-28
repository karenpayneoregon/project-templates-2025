# Copilot Instructions for ConsoleWithEntityFrameworkCoreSqlServer2025

## Project Overview

This is a .NET 9.0 console application template using Entity Framework Core and SQL Server. It demonstrates modern C# patterns, dependency injection, configuration management, and structured logging.

## Key Components

- **Program Entry**:  
  - `Program.cs` (root and `Classes/`) contains the main entry point and initialization logic.
  - Uses `[ModuleInitializer]` for early setup (window positioning, logging).
- **Configuration**:  
  - `appsettings.json` holds connection strings and entity configuration flags.
  - `ConsoleConfigurationLibrary` and `ConsoleHelperLibrary` are used for configuration and console utilities.
- **Logging**:  
  - `SetupLogging.cs` configures Serilog for file-based logging, with log files stored in `LogFiles` under the app base directory.
- **Dependency Injection**:  
  - Services are registered and resolved via `ConfigureServices()` (see `Setup()` in `Program.cs`).
- **Global Usings**:  
  - `GlobalUsings.cs` provides project-wide imports for helper libraries and Spectre.Console.

## Build & Run

- Build with Visual Studio 2022 or `dotnet build` targeting `net9.0`.
- Run with `dotnet run` or from VS.
- No custom build/test scripts detected; standard .NET CLI applies.

## Patterns & Conventions

- **Namespace**:  
  - All code is under `ConsoleWithEntityFrameworkCoreSqlServer2025`.
- **Class Placement**:  
  - Supporting classes are in `Classes/`.
- **Logging**:  
  - Always initialize logging via `SetupLogging.Development()` before other operations.
- **Configuration Access**:  
  - Use DI to access configuration and entity settings (`SetupServices` pattern).
- **Console Output**:  
  - Use `Spectre.Console` for rich console output (`AnsiConsole.MarkupLine`).

## External Dependencies

- NuGet packages:  
  - `Serilog`, `Serilog.Sinks.File`, `Spectre.Console`, `ConsoleHelperLibrary`, `ConsoleConfigurationLibrary`, `SeriLogThemesLibrary`
- SQL Server:  
  - Connection string in `appsettings.json` expects a local `SQLEXPRESS` instance and `AppsettingsConfigurations` database.

## Example: Logging Setup

```csharp
SetupLogging.Development();
Log.Information("Application started");
```

## Example: DI Service Usage

```csharp
var services = ConfigureServices();
using var provider = services.BuildServiceProvider();
var setup = provider.GetService<SetupServices>();
setup.GetConnectionStrings();
setup.GetEntitySettings();
```

## File References

📄 `Program.cs` (root): Main entry, initialization

🛠️ `Classes/SetupLogging.cs`: Logging configuration

🗄️ `Classes/DataOperations.cs`: Data access (template, extend as needed)

🌐 `GlobalUsings.cs`: Global imports

⚙️ `appsettings.json`: Configuration

---

Please review and let me know if any sections need clarification or if there are additional project-specific patterns to document.
