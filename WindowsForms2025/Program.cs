using Microsoft.Extensions.DependencyInjection;
using WindowsForms2025.Classes;

namespace WindowsForms2025;
internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        SetupLogging.Development();
        Application.Run(new MainForm());
    }

}