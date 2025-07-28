# Copilot Instructions for MsTest2025

## Project Overview
This is a .NET 9 MSTest project template designed for rapid test development and extension. The codebase is organized for clarity and extensibility, with conventions that differ from standard MSTest setups.

## Architecture & Key Components
- **Test Classes**: Located in the root and `Base/` directory. All test classes should inherit from `BaseConfiguration` for shared context and result management.
- **BaseConfiguration**: Centralizes `TestContext` handling and aggregates test results. See `Base/BaseConfiguration.cs`.
- **Traits System**: Custom trait categorization via `TestTraitsAttribute` and the `Trait` enum in `Base/TestTraitsAttribute.cs`. Use `[TestTraits(...)]` to tag tests for filtering and organization.
- **Test Initialization**: Use `[TestInitialize]` and `[ClassInitialize]` for setup. See `Base/Test1.cs` for static result list initialization.
- **PlaceHolder Classes**: `Classes/` and `Models/` folders contain placeholders for future domain logic and data models.

## Developer Workflows
- **Build**: Standard .NET build. Use `dotnet build` from the project root.
- **Test**: Run tests with `dotnet test`. Parallelization is enabled by default via `[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]` in `MSTestSettings.cs`. To disable, use `[assembly: DoNotParallelize]`.
- **Assertions**: Prefer `NFluent` and `FluentAssertions` for expressive test assertions. See `Test1.cs` for usage examples.
- **Test Categories**: Filter tests by trait using MSTest's category system, e.g., `dotnet test --filter TestCategory=Numbers`.

## Patterns & Conventions
- **Partial Classes**: Test classes may be split using `partial` for organization.
- **Static TestResults**: All test results are aggregated in a static list for post-run analysis.
- **Explicit Usings**: Project uses implicit usings and nullable reference types (`MsTest2025.csproj`).
- **No README/Docs**: All conventions are documented here; no external markdown files exist.

## External Dependencies
- **NuGet Packages**: `FluentAssertions`, `NFluent`, `Microsoft.NET.Test.Sdk`, `MSTest`.
- **No External Services**: All logic is local; no API or DB integration.

## Example: Adding a Test
```csharp
[TestClass]
public sealed partial class MyTest : BaseConfiguration
{
    [TestMethod]
    [TestTraits(Numbers)]
    public void Addition_Works()
    {
        Check.That(2 + 2).Equals(4);
    }
}
```

## Key Files & Directories
- `MsTest2025.csproj`: Project configuration and dependencies
- `Base/BaseConfiguration.cs`: Shared test context logic
- `Base/TestTraitsAttribute.cs`: Custom trait system
- `Test1.cs`: Example test class
- `MSTestSettings.cs`: Parallelization settings

---
For questions or unclear conventions, review the above files or ask for clarification. Update this file if new patterns or workflows are introduced.
