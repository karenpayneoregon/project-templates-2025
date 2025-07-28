# Copilot Instructions for SpectreConsoleLibrary

## Project Overview
- **Purpose:** Utility library for Spectre.Console, providing helper methods for console rendering and formatting.
- **Main Components:**
  - `Helpers.cs`: Contains static helper methods for rendering rules, printing method names, line separators, and escaping/removing Spectre.Console markup.
  - `SpectreConsoleLibrary.csproj`: .NET 9.0 project file, references Spectre.Console v0.46.0.

## Architecture & Patterns
- All logic is in static methods within `Helpers.cs` under the `SpectreConsoleLibrary` namespace.
- Methods use Spectre.Console's `AnsiConsole`, `Markup`, and `Rule` for output formatting.
- Extension methods (`ConsoleEscape`, `ConsoleRemove`) are used for string markup handling.
- Follows .NET conventions for static utility libraries.

## Developer Workflows
- **Build:**
  - Use Visual Studio 2022 or run `dotnet build` from the project root.
  - Target framework: `net9.0` (ensure .NET 9 SDK is installed).
- **Dependencies:**
  - Spectre.Console is referenced via NuGet in the `.csproj`.
- **Debug/Test:**
  - No test files or test projects present; add tests in a separate project if needed.
  - Debug using standard Visual Studio or `dotnet run` workflows.

## Project-Specific Conventions
- Markup escaping and removal are handled via extension methods on `string`.
- Console output is styled using Spectre.Console markup and rules for clarity and separation.
- Method names are printed in cyan for demo/diagnostic purposes (`PrintCyan`).
- Exit prompts and separators use custom styles (`silver`, `grey`).

## Integration Points
- Only external dependency is Spectre.Console.
- No cross-component communication; all logic is local to the library.

## Key Files
- `Helpers.cs`: All helper logic and patterns.
- `SpectreConsoleLibrary.csproj`: Project configuration and dependencies.

## Example Usage
```csharp
Helpers.PrintCyan(); // Prints the calling method name in cyan
Helpers.LineSeparator(); // Prints a styled separator
"Children[0].Name".ConsoleEscape(); // Escapes Spectre.Console markup
"[cyan]Hello[/]".ConsoleRemove(); // Removes Spectre.Console markup
```

---
_If any conventions or workflows are unclear, please provide feedback so this guide can be improved._
