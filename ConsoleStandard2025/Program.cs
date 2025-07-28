using ConsoleStandard2025.Classes;
using Serilog;

namespace ConsoleStandard2025;

internal partial class Program
{
    static void Main(string[] args)
    {
        Log.Information("Application started");
        DataOperations.GetSettings();
        SpectreConsoleHelpers.ExitPrompt();
    }
}