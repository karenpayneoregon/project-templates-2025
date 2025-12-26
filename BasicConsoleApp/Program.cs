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
        SpectreConsoleHelpers.ErrorPill(Justify.Left);
        SpectreConsoleHelpers.WarningPill(Justify.Left);
        SpectreConsoleHelpers.InfoPill(Justify.Left);
        SpectreConsoleHelpers.SuccessPill(Justify.Left);
        SpectreConsoleHelpers.ExitPrompt(Justify.Left);
    }
}
