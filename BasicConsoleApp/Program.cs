// for samples
using Spectre.Console;
using SpectreConsoleLibrary;
using System.Reflection.Emit;

namespace BasicConsoleApp;
internal partial class Program
{
    private static void Main(string[] args)
    {
        
        SpectreConsoleHelpers.WindowTitle(Justify.Left);
        SpectreConsoleHelpers.ErrorPill(Justify.Left, "Error: Something went wrong");
        SpectreConsoleHelpers.WarningPill(Justify.Left, "Potential issue detected");
        SpectreConsoleHelpers.InfoPill(Justify.Left, "Time to backup data");
        SpectreConsoleHelpers.SuccessPill(Justify.Left, "Operation completed successfully");
        SpectreConsoleHelpers.ExitPrompt(Justify.Left);
    }
}
