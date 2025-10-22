using Spectre.Console;
using System.Runtime.CompilerServices;

namespace BasicConsoleProject.Classes.Configuration;
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

    private static void Render(Rule rule)
    {
        AnsiConsole.Write(rule);
        AnsiConsole.WriteLine();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="methodName"></param>
    /// <param name="filePath"></param>
    public static void PrintCyan([CallerMemberName] string? methodName = null, [CallerFilePath] string filePath = "")
    {
        AnsiConsole.MarkupLine($"[cyan]{Path.GetFileNameWithoutExtension(filePath)}.{methodName}[/]");
        Console.WriteLine();
    }

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
}