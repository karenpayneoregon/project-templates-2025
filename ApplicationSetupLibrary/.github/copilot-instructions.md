# Copilot Instructions for ApplicationSetupLibrary

## Project Overview
- This is a .NET 9.0 class library focused on configuration management and helper utilities for application setup.
- Key files: `Configuration.cs`, `ConfigurationHelpers.cs`, `Helpers.cs`.
- The library centralizes configuration loading from JSON files, environment variables, and user secrets.

## Architecture & Patterns
- **Configuration Access:**
  - Use `Configuration.JsonRoot()` to load settings from `appsettings.json` and environment variables.
  - Use `Configuration.JsonRootSecrets()` to also include user secrets and environment-specific JSON files.
- **Helpers:**
  - `Helpers.SectionExists(string sectionName)` and `ConfigurationHelpers.SectionExists(string sectionName)` check for the existence of configuration sections.
  - `Helpers.GetSetting1<T>(string section, string name)` retrieves strongly-typed values from configuration, returning default on error.
- **Extension Packages:**
  - Relies on Microsoft.Extensions.* packages for configuration, DI, and logging (see `.csproj`).

## Developer Workflows
- **Build:**
  - Standard .NET build: `dotnet build` from the project root.
- **Debug:**
  - Use Visual Studio or `dotnet test` if tests are added (no test files present by default).
- **Configuration Files:**
  - The library expects `appsettings.json` in the working directory. Environment-specific files (`appsettings.{environment}.json`) are optional.
  - User secrets are supported via `AddUserSecrets`.

## Conventions & Practices
- **Nullable Reference Types:** Enabled by default.
- **Implicit Usings:** Enabled for .NET 9.0.
- **Error Handling:** Helper methods return default values on error, rather than throwing.
- **Static Helper Classes:** All configuration access is via static methods for simplicity.
- **No Custom Build/Debug Scripts:** All workflows use standard .NET CLI or IDE features.

## Integration Points
- **External Dependencies:**
  - Microsoft.Extensions.Configuration (JSON, EnvironmentVariables, UserSecrets)
  - Microsoft.Extensions.DependencyInjection
  - Microsoft.Extensions.Logging
- **No direct cross-component communication:**
  - All logic is contained within the library; integration is via consuming applications.

## Example Usage
```csharp
// Check if a section exists
bool exists = Helpers.SectionExists("MySection");

// Get a strongly-typed setting
int timeout = Helpers.GetSetting1<int>("MySection", "Timeout");
```

## Key Files
- `Configuration.cs`: Main configuration builder logic
- `Helpers.cs`, `ConfigurationHelpers.cs`: Utility methods for configuration access
- `ApplicationSetupLibrary.csproj`: Dependency and build settings

---
_If any section is unclear or missing, please provide feedback to improve these instructions._
