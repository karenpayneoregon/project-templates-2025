# Copilot Instructions — SpectreConsoleLibrary

Purpose
- Small utility library providing Spectre.Console helper methods and string extensions for markup handling.

Quick Start (developer)
- Build: `dotnet build` (project targets `net9.0` — ensure .NET 9 SDK is installed)
- Run sample/debug: open the project in Visual Studio 2022 or use `dotnet run` from a test/host project that references this library.

Key Files
- `Helpers.cs` — central place for console helpers and extension methods (escape/remove markup, separators, styled printing).
- `SpectreConsoleLibrary.csproj` — target framework and NuGet references (Spectre.Console dependency).

Patterns & Conventions (discoverable)
- Helpers are implemented as static methods in `Helpers.cs` inside the `SpectreConsoleLibrary` namespace.
- String markup handling is exposed via extension methods (e.g., `ConsoleEscape()`, `ConsoleRemove()`) — prefer using these when preparing text for Spectre.Console output.
- Console output uses Spectre.Console markup and `AnsiConsole`/`Rule` objects for consistent separators and styles.

Examples (from codebase patterns)
```
Helpers.PrintCyan();         // prints caller/method name in cyan for quick diagnostics
Helpers.LineSeparator();      // prints a styled rule/separator via Spectre.Console
"[cyan]Hello[/]".ConsoleRemove(); // remove Spectre markup from a string
"Children[0].Name".ConsoleEscape(); // escape characters to avoid Spectre markup parsing
```

Developer Notes for Agents
- Preserve method naming and extension patterns when adding helpers to keep API consistent.
- Avoid adding runtime dependencies beyond Spectre.Console unless necessary; this project is intentionally small and dependency-light.
- No test project present — if you add tests, create a separate `tests` project and reference this library.

Build & Debug Tips
- Use `dotnet build` and IDE debug in Visual Studio 2022 for interactive inspection.
- If packing/publishing is needed, add a consumer project (console app) to exercise runtime behavior; current repo is a library template.

Where to Look Next
- `Helpers.cs` for canonical helper implementations.
- `SpectreConsoleLibrary.csproj` for package/version constraints.

Feedback
- If anything here is incorrect or you'd like more examples or a tiny runnable demo project added, tell me and I'll update the file.
