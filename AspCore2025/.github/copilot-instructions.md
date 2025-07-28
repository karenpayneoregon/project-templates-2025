# Copilot Instructions for AspCore2025

## Project Overview
- This is an ASP.NET Core 9.0 web application using Razor Pages.
- Main entry: `Program.cs`.
- Page logic and UI are in `Pages/` (e.g., `Index.cshtml`, `About.cshtml`, and their code-behind files).
- Shared layout and styles: `Pages/Shared/_Layout.cshtml`, `Pages/Shared/_Layout.cshtml.css`.
- Static assets: `wwwroot/` (CSS, JS, Bootstrap, jQuery, validation libraries).

## Architecture & Data Flow
- Configuration and validation logic is in `Classes/Configuration/` (e.g., `LogOperations.cs`, `SqlConnectionValidator.cs`).
- Strongly-typed configuration models in `Models/Configuration/` (e.g., `HelpDesk.cs`, `ConnectionStrings.cs`).
- Help desk info is injected into the layout via `IOptions<HelpDesk>` and displayed in the footer.
- UI uses Bootstrap for layout and styling, with customizations in `site.css` and `_Layout.cshtml.css`.
- Sidebar and off-canvas UI logic is handled in `wwwroot/js/sidebar.js` and referenced in `Index.cshtml`.

## Developer Workflows
- Build and run: Use Visual Studio or `dotnet run` from the project root. Launch profiles are defined in `Properties/launchSettings.json`.
- Debugging: Use Visual Studio's built-in debugger. Environment variables are set via launch profiles.
- Static assets are versioned and bundled automatically; see comments in CSS files for bundling/minification details.
- Logging: Serilog is referenced (see `bin/Debug/net9.0/Serilog.*.dll`), with log files output to `bin/Debug/net9.0/LogFiles/`.

## Conventions & Patterns
- Razor Pages use code-behind files for page logic (e.g., `Index.cshtml.cs`).
- Shared UI elements and scripts are placed in `Pages/Shared/` and referenced via layout.
- Configuration is injected using `IOptions<T>` and accessed in views via `@inject`.
- Custom JS for UI interactions is placed in `wwwroot/js/` and loaded via layout or page sections.
- External libraries (Bootstrap, jQuery, validation) are managed in `wwwroot/lib/`.

## Integration Points
- No direct database code found; connection strings and validators are present for future integration.
- Logging via Serilog; ensure configuration if extending logging features.
- Static web assets are managed via ASP.NET Core conventions and referenced in Razor views.

## Examples
- Injecting config: `@inject IOptions<HelpDesk> HelpDeskOptions` in `_Layout.cshtml`.
- Custom sidebar toggle: see `wwwroot/js/sidebar.js` and usage in `Index.cshtml`.
- Adding a new page: create `Pages/NewPage.cshtml` and `Pages/NewPage.cshtml.cs`.

---

If any section is unclear or missing, please provide feedback to improve these instructions.
