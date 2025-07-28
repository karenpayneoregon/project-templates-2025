# Copilot Coding Agent Instructions for AspCoreSeriLogging2025

## Project Overview
- ASP.NET Core 9.0 web application template focused on structured logging using Serilog.
- Main entry: `Program.cs` sets up the web host, configures logging, and registers services.
- Logging is environment-aware: console output in development, file output in production (see `Classes/Configuration/LogOperations.cs`).
- Razor Pages are used for UI (`Pages/`).
- Configuration models are in `Models/Configuration/`.

## Architecture & Data Flow
- Logging setup is centralized via the extension method `SetupSerilog(WebApplicationBuilder)` in `LogOperations.cs`.
- App configuration is loaded from `appsettings.json` and `appsettings.Development.json`.
- Service registration and configuration binding are performed in `Program.cs`.
- Static assets are served from `wwwroot/` and mapped via `app.MapStaticAssets()`.

## Developer Workflows
- **Build:** Use standard .NET CLI or Visual Studio build commands. Target framework is `net9.0`.
- **Run:** `dotnet run` from the project root, or use Visual Studio F5.
- **Debug:** Standard Visual Studio or VS Code debugging for ASP.NET Core.
- **Logging:**
  - In development, logs appear in the console.
  - In production, logs are written to `LogFiles/YYYY-MM-DD/Log.txt` (auto-created).
- **Configuration:**
  - Update logging and app settings in `appsettings.json` or environment-specific files.

## Conventions & Patterns
- Logging configuration is not in `Program.cs` directly, but via the extension in `LogOperations.cs`.
- All configuration models should be placed in `Models/Configuration/`.
- Razor Pages follow standard ASP.NET Core conventions.
- Static assets (CSS, JS, etc.) are in `wwwroot/`.

## Integration Points & Dependencies
- **Serilog.AspNetCore** is the primary logging package (see `.csproj`).
- Other Serilog sinks (Console, File, Debug) are referenced and configured in `LogOperations.cs`.
- Uses Microsoft.Extensions.* packages for configuration, dependency injection, and hosting.

## Examples
- To add a new configuration model, place it in `Models/Configuration/` and bind in `Program.cs`:
  ```csharp
  builder.Services.Configure<MyConfig>(builder.Configuration.GetSection(nameof(MyConfig)));
  ```
- To customize logging, edit `SetupSerilog` in `LogOperations.cs`.

## Key Files
- `Program.cs`: App startup, service registration, pipeline config.
- `Classes/Configuration/LogOperations.cs`: Centralized logging setup.
- `appsettings.json`, `appsettings.Development.json`: Configuration sources.
- `AspCoreSeriLogging2025.csproj`: Project dependencies and target framework.
- `Pages/`: Razor Pages UI.
- `wwwroot/`: Static assets.

---
For questions or unclear conventions, review `LogOperations.cs` and `Program.cs` for current patterns. Ask for feedback if any workflow or pattern is ambiguous.
