# Copilot Instructions for WindowsForms2025

## Project Overview
- This is a .NET 8 Windows Forms application, using modern .NET SDK and implicit usings.
- Main entry point: `Program.cs` (calls `SetupLogging.Development()` and launches `MainForm`).
- Logging is handled via Serilog, configured in `Classes/SetupLogging.cs` to write daily log files to `LogFiles/`.
- Application configuration is loaded via `ApplicationConfiguration.Initialize()` and `appsettings.json` (copied to output directory).

## Key Components
- `MainForm.cs`: Main UI form, logs initialization.
- `Classes/SetupLogging.cs`: Centralized logging setup for development.
- External libraries: Serilog, Dapper, Microsoft.Data.SqlClient, ConfigurationLibrary, ConsoleConfigurationLibrary.

## Developer Workflow
- **Build**: Use standard .NET build commands (`dotnet build` or build in Visual Studio).
- **Run**: Launch via Visual Studio or `dotnet run` from project root.
- **Logs**: Find logs in `LogFiles/YYYY-MM-DD/Log.txt` (created per day).
- **Configuration**: Edit `appsettings.json` for runtime settings.

## Patterns & Conventions
- Logging is always initialized at startup via `SetupLogging.Development()`.
- All forms/components should use Serilog for logging (see `MainForm.cs` for example).
- Use dependency injection via `Microsoft.Extensions.DependencyInjection` for services (see `Program.cs`).
- External configuration libraries are referenced for advanced settings (see project file for details).

## Integration Points
- Database access via Dapper and `Microsoft.Data.SqlClient` (connection strings/configuration expected in `appsettings.json`).
- Logging via Serilog, with file sink and rolling file conventions.
- Configuration via `ConfigurationLibrary` and `ConsoleConfigurationLibrary`.

## File/Directory References
- `Program.cs`, `MainForm.cs`, `Classes/SetupLogging.cs`, `appsettings.json`, `WindowsForms2025.csproj`
- Log output: `LogFiles/`

## Example: Logging Setup
```csharp
Log.Logger = new LoggerConfiguration()
    .WriteTo.File(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LogFiles", $"{Now.Year}-{Now.Month:d2}-{Now.Day:d2}", "Log.txt"),
        rollingInterval: RollingInterval.Infinite,
        outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level}] {Message}{NewLine}{Exception}")
    .CreateLogger();
```

---
If any section is unclear or missing, please provide feedback to improve these instructions.
