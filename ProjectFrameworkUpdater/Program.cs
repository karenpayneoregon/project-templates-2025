using ProjectFrameworkUpdater.Classes.Core;
using Spectre.Console;

namespace ProjectFrameworkUpdater
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            SpectreConsoleHelpers.PrintPink();

            var rootFolder = @"C:\DotnetLand\VS2026\project-templates-2025";

            TargetFrameworkUpdater.Update(rootFolder);
            
            SpectreConsoleHelpers.ExitPrompt(Justify.Left);

        }
    }
}
