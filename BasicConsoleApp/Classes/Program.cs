using ConsoleHelperLibrary.Classes;
using System.Reflection;
using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace BasicConsoleApp;
internal partial class Program
{
    /// <summary>
    /// Initializes the console application by setting up the console window title, 
    /// positioning the console window, and configuring development logging.
    /// </summary>
    [ModuleInitializer]
    public static void Init()
    {
        var assembly = Assembly.GetEntryAssembly();
        var product = assembly?.GetCustomAttribute<AssemblyProductAttribute>()?.Product;

        Console.Title = product!;

        //WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);

    }
}
