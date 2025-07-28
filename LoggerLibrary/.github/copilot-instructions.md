# Copilot Instructions for LoggerLibrary

## Project Overview

This is a .NET 9.0 class library for advanced logging, primarily using Serilog and custom file-based loggers. It is designed for developer productivity, with extensible logging themes and support for Entity Framework (DbContext) logging.

## Key Components

- **SetupLogging.cs**: Provides static methods to configure Serilog for file-based logging. Log files are created in `LogFiles/YYYY-MM-DD/Log.txt` under the app base directory.
- **SeriLogCustomThemes.cs**: Defines custom Serilog console themes (e.g., `KarenConsoleTheme`) for colored log output. Extend or modify these for custom console styling.
- **DbContextToFileLogger.cs**: Simple logger for Entity Framework contexts. Writes to `LogFiles/YYYY-MM-DD/EF_Log.txt`. No exception handling—intended for local developer use.

## Build & Developer Workflow

- Build with standard .NET commands (`dotnet build`).
- Target framework: `net9.0`.
- Logging output is file-based; ensure the process has permission to create directories/files under the app base directory.
- If using `DbContextToFileLogger`, ensure the `LogFiles` directory exists. The project file may include a custom action (search for `MakeLogDir` in `.csproj`) to create this folder.

## Patterns & Conventions

- **File-based Logging**: All logs are written to dated subfolders under `LogFiles`. This pattern is consistent across all loggers.
- **No Exception Handling in Loggers**: Logging classes are intentionally void of exception handling for developer simplicity.
- **Customizable Themes**: Console themes are defined in a dedicated class. Add new themes or modify existing ones as needed.
- **Extensibility**: Consider extracting loggers into a separate project and packaging as a local NuGet for reuse.

## External Dependencies

- Serilog (`Serilog`, `Serilog.Sinks.File`, `Serilog.Extensions.Logging.File`)
- SeriLogThemesLibrary

## Integration Points

- Designed to be integrated into other projects for logging needs.
- DbContext logger is intended for use with Entity Framework, but can be adapted for other contexts.

## Example Usage

```csharp
SetupLogging.Development(); // Initializes Serilog file logging

var logger = new DbContextToFileLogger();
logger.Log("EF context started"); // Writes to EF_Log.txt
```

## Important Files

- `SetupLogging.cs`: Logging setup logic
- `SeriLogCustomThemes.cs`: Console theme definitions
- `DbContextToFileLogger.cs`: File logger for EF contexts
- `LoggerLibrary.csproj`: Build targets and dependencies

---

Please review and let me know if any section is unclear or missing details. I can iterate further based on your feedback.
