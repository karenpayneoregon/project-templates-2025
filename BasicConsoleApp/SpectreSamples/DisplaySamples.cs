// required for MonthNames
using System.Globalization;
// required for PrintCyan
using BasicConsoleApp.Classes.Utility;
using Spectre.Console.Rendering;
using SpectreConsoleLibrary2025;

namespace BasicConsoleApp.SpectreSamples;

internal class DisplaySamples
{
    /// <summary>
    /// Demonstrates the use of a <c>for</c> loop to iterate through a collection of month names
    /// and displays them in alternating colors using Spectre.Console.
    /// </summary>
    /// <remarks>
    /// This method utilizes the <see cref="Spectre.Console.AnsiConsole"/> to format and display
    /// the month names. Even-indexed months are displayed in "cadetblue" color, while odd-indexed
    /// months are displayed in "hotpink2" color.
    /// </remarks>
    public static void ForStatementIsEven()
    {
        SpectreConsoleHelpers.PrintCyan();

        var months = DateTimeFormatInfo.CurrentInfo.MonthNames[..^1].ToList();

        for (var i = 0; i < months.Count; i++)
        {
            if (i % 2 == 0)
            {
                // -5 is for left alignment within a 5 character width
                AnsiConsole.MarkupLine($"[cadetblue]{i +1,-5}{months[i]}[/]");
            }
            else
            {
                AnsiConsole.MarkupLine($"[hotpink2]{i +1,-5}{months[i]}[/]");
            }
        }
    }

    /// <summary>
    /// Demonstrates the creation and display of a table using Spectre.Console.
    /// </summary>
    /// <remarks>
    /// This method creates a table with two columns: "Index" and "Name". It populates the table
    /// with the indices and names of months retrieved from the current culture's month names.
    /// The table is then displayed in the console using <see cref="Spectre.Console.AnsiConsole.Write(IRenderable)"/>.
    /// </remarks>
    public static void TableExample()
    {
        SpectreConsoleHelpers.PrintCyan();

        var months = DateTimeFormatInfo.CurrentInfo.MonthNames[..^1].ToList();
        
        var table = new Table();
        table.Title("[yellow]Month Names[/]");
        table.AddColumn("[b][u]Index[/][/]");
        table.AddColumn("[b][u]Name[/][/]");

        for (var i = 0; i < months.Count; i++)
        {
            table.AddRow($"{i + 1}", months[i]);
        }

        AnsiConsole.Write(table);
    }

    /// <summary>
    /// Demonstrates the usage of various pill-shaped UI elements in the console, 
    /// including error, warning, informational, and success messages.
    /// </summary>
    /// <remarks>
    /// This method utilizes the <see cref="SpectreConsoleHelpers"/> class to render 
    /// visually distinct pill elements with different styles and alignments.
    /// </remarks>
    public static void PillExamples()
    {
        SpectreConsoleHelpers.WindowTitle(Justify.Left);
        SpectreConsoleHelpers.ErrorPill(Justify.Left, "Error: Something went wrong");
        SpectreConsoleHelpers.WarningPill(Justify.Left, "Potential issue detected");
        SpectreConsoleHelpers.InfoPill(Justify.Left, "Time to backup data");
        SpectreConsoleHelpers.SuccessPill(Justify.Left, "Operation completed successfully");
    }
}
