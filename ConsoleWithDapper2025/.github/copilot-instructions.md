# Copilot Instructions for ConsoleWithDapper2025

## Project Overview
- This is a .NET console application template targeting `net9.0`.
- Main features: configuration management, logging, and database access using Dapper.
- Key external libraries: Serilog (logging), Dapper (ORM), Microsoft.Data.SqlClient (SQL Server access), Spectre.Console (console UI), and custom configuration libraries.

## Architecture & Data Flow
- Entry point: `Program.cs` (root) and `Classes/Program.cs` (contains initialization logic).
- Configuration is loaded from `appsettings.json` and custom configuration libraries.
- Logging is set up via `SetupLogging.Development()` (see `Classes/SetupLogging.cs`). Log files are written to `LogFiles/YYYY-MM-DD/Log.txt`.
- Database connections use connection strings from `appsettings.json` via `DataOperations` and `ConnectionStrings` model.
- Dependency injection is configured in `Classes/Program.cs` using `ConfigureServices()` (from external library).

## Developer Workflows
- **Build:** Use standard .NET build commands (`dotnet build`).
- **Run:** Use `dotnet run` or launch from Visual Studio.
- **Debug:** Standard Visual Studio/.NET debugging applies. Console title and window position are set for clarity.
- **Logging:** Check log files in `LogFiles/` for diagnostics.
- **Configuration:** Update `appsettings.json` for connection strings and entity settings.

## Project-Specific Conventions
- All main logic is in the `Classes/` folder; root `Program.cs` is minimal.
- Uses partial classes for `Program` to separate concerns.
- Global usings are defined in `GlobalUsings.cs`.
- Connection strings and entity configuration are modeled in `Models/Configuration/ConnectionStrings.cs` and `appsettings.json`.
- Logging is always initialized at startup using Serilog.
- Console UI enhancements via Spectre.Console.

## Integration Points
- Relies on custom configuration libraries (`ConfigurationLibrary`, `ConsoleConfigurationLibrary`, `ConsoleHelperLibrary`).
- Database access is via Dapper and Microsoft.Data.SqlClient.
- Logging uses Serilog and related sinks/extensions.

## Examples
- To add a new service, update `ConfigureServices()` in the external configuration library and consume via DI in `Classes/Program.cs`.
- To change database, update `MainConnection` in `appsettings.json`.
- To customize logging, modify `SetupLogging.Development()`.

## Key Files & Directories
- `Classes/Program.cs`: Initialization and DI setup
- `Classes/SetupLogging.cs`: Logging configuration
- `Classes/DataOperations.cs`: Database connection
- `Models/Configuration/ConnectionStrings.cs`: Connection string model
- `appsettings.json`: Configuration source
- `GlobalUsings.cs`: Global using directives

---
If any section is unclear or missing, please provide feedback to improve these instructions.
