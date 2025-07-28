# Copilot Instructions for WpfApp2025

## Project Overview

- **Type:** WPF desktop application (.NET 9, Windows)
- **Main Components:**
  - UI: `MainWindow.xaml` and `MainWindow.xaml.cs`
  - ViewModels: Located in `ViewModels/` (e.g., `MainWindowViewModel.cs`, `RelayCommand.cs`)
  - Logging setup: `Classes/SetupLogging.cs`
  - Assets: Images and resources in `Assets/`
  - Entry point: `App.xaml` and `App.xaml.cs`

## Architecture & Patterns

- **MVVM Pattern:** ViewModels are separated from Views. Use `RelayCommand` for command binding.
- **Dependency Injection:** Uses `Microsoft.Extensions.DependencyInjection.Abstractions` for service registration.
- **Logging:** Integrated with Serilog (see `SetupLogging.cs`). Log files are written to `bin/Debug/net9.0-windows/LogFiles/YYYY-MM-DD/`.
- **Resource Management:** Images (e.g., `exit.png`) are referenced via pack URIs in XAML.

## Developer Workflows

- **Build:** Use standard .NET build commands (`dotnet build` or build via Visual Studio).
- **Run:** Launch via Visual Studio or `dotnet run` from the project root.
- **Debug:** Set breakpoints in code-behind or ViewModel files. Use Visual Studio's WPF designer for UI debugging.
- **Assets:** Add new images to `Assets/` and reference them in XAML using `pack://application:,,,/Assets/filename.png`.

## Conventions

- **ViewModels:** Place all ViewModel classes in `ViewModels/`. Use the `RelayCommand` pattern for ICommand implementations.
- **Logging:** Configure logging in `SetupLogging.cs`. All logs are written using Serilog; do not use other logging frameworks.
- **XAML:** UI logic should remain in XAML and code-behind. Avoid placing business logic in code-behind; use ViewModels instead.
- **External Dependencies:** Managed via NuGet; see `WpfApp2025.csproj` for package references.

## Integration Points

- **Serilog:** Logging is set up to write to rolling files. If adding new logging sinks, update `SetupLogging.cs`.
- **Microsoft.Extensions:** Configuration, Dependency Injection, and Logging abstractions are used for extensibility.

## Examples

- **Command Binding:**
  ```csharp
  public RelayCommand ExitCommand { get; }
  // Bind to button in XAML: Command="{Binding ExitCommand}"
  ```
- **Logging Usage:**
  ```csharp
  Log.Information("App started");
  ```

## Key Files

📄 `MainWindow.xaml` / `MainWindow.xaml.cs`: Main UI

📄 `ViewModels/MainWindowViewModel.cs`: Main ViewModel

📄 `Classes/SetupLogging.cs`: Logging configuration

📁 `Assets/`: Static resources


