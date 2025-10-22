using KP_Console2025.Classes;
using KP_Console2025.Classes.Configuration;

namespace KP_Console2025;

internal partial class Program
{
    static void Main(string[] args)
    {
        DataOperations.GetSettings(); 
        SpectreConsoleHelpers.ExitPrompt();
    }
}
