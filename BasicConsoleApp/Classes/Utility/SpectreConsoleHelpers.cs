using Spectre.Console;
using System.Runtime.CompilerServices;
using System.Text;

namespace BasicConsoleApp.Classes.Utility;
public static class SpectreConsoleHelpers
{
    /// <summary>
    /// Displays a prompt to the user indicating that they can press any key to exit the application.
    /// </summary>
    public static void ExitPrompt()
    {
        Console.WriteLine();
        AnsiConsole.MarkupLine("[bold cyan]Press any key to exit...[/]");

        Console.ReadLine();
    }

    /// <summary>
    /// Prints the name of the calling method in cyan color to the console.
    /// </summary>
    /// <param name="filePath">
    /// The file path of the source code file containing the calling method. 
    /// This parameter is optional and is automatically populated with the file path of the caller, if not explicitly provided.
    /// </param>
    /// <param name="methodName">
    /// The name of the calling method. 
    /// This parameter is optional and is automatically populated with the name of the method that invoked this method, if not explicitly provided.
    /// </param>
    public static void PrintCyan([CallerFilePath] string? filePath = null, [CallerMemberName] string? methodName = null)
    {
        AnsiConsole.MarkupLine($"[cyan]{Path.GetFileNameWithoutExtension(filePath)}.{methodName}[/]");
        Console.WriteLine();
    }

    /// <summary>
    /// Displays a horizontal line separator in the console using Spectre.Console.
    /// </summary>
    public static void LineSeparator()
    {
        AnsiConsole.Write(new Rule().RuleStyle(Style.Parse("grey")).Centered());
    }

    /// <summary>
    /// Spectre.Console  Add [ to [ and ] to ] so Children[0].Name changes to Children[[0]].Name
    /// </summary>
    /// <param name="sender"></param>
    /// <returns></returns>
    public static string ConsoleEscape(this string sender)
        => Markup.Escape(sender);

    /// <summary>
    /// Spectre.Console Removes markup from the specified string.
    /// </summary>
    /// <param name="sender"></param>
    /// <returns></returns>
    public static string ConsoleRemove(this string sender)
        => Markup.Remove(sender);

    /// <summary>
    /// Configures the console to support UTF-8 encoding for input and output, enabling the use of emojis.
    /// </summary>
    public static void UseEmojis()
    {
        Console.OutputEncoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
        Console.InputEncoding = Encoding.UTF8;
    }

}