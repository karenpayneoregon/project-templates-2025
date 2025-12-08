using Spectre.Console;

namespace BasicConsoleApp.Classes.Utility;

/// <summary>
/// Provides utility methods for prompting user input in the console application.
/// </summary>
internal class Prompts
{
    /// <summary>
    /// Prompts the user to enter a date via the console.
    /// </summary>
    /// <param name="text">
    /// The text to display in the prompt, indicating what the user should enter. Defaults to "Enter a date".
    /// </param>
    /// <returns>
    /// A <see cref="DateOnly"/> value entered by the user, or <c>null</c> if the user chooses not to enter a date.
    /// </returns>
    public static DateOnly? GetDate(string text = "Enter a date") =>
        AnsiConsole.Prompt(new TextPrompt<DateOnly>($"Enter [white]{text}[/]")
                .PromptStyle("yellow")
                .ValidationErrorMessage("[red]Please enter a valid date or press ENTER to not enter a date[/]")
                .AllowEmpty());

    /// <summary>
    /// Prompts the user to enter an integer via the console.
    /// </summary>
    /// <param name="text">
    /// The text to display in the prompt, indicating what the user should enter. Defaults to "Enter an integer".
    /// </param>
    /// <returns>
    /// An <see cref="int"/> value entered by the user.
    /// </returns>
    public static int GetInt(string text = "Enter an integer") =>
        AnsiConsole.Prompt(new TextPrompt<int>($"[white]Enter {text}[/]")
                .PromptStyle("cyan")
                .ValidationErrorMessage("[red]That's not a valid integer[/]"));

    /// <summary>
    /// Prompts the user to enter a string via the console.
    /// </summary>
    /// <param name="text">
    /// The text to display in the prompt, indicating what the user should enter. Defaults to "Enter a string".
    /// </param>
    /// <returns>
    /// A <see cref="string"/> value entered by the user, or an empty string if the user chooses not to enter any input.
    /// </returns>
    public static string GetString(string text = "Enter a string") =>
        AnsiConsole.Prompt(
            new TextPrompt<string>($"[white]{text}[/]")
                .AllowEmpty());


    /// <summary>
    /// Prompts the user to enter a value of the specified type via the console.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the value to be entered by the user.
    /// </typeparam>
    /// <param name="prompt">
    /// The text to display in the prompt, indicating what the user should enter.
    /// </param>
    /// <param name="defaultValue">
    /// The default value to use if the user does not provide any input.
    /// </param>
    /// <returns>
    /// A value of type <typeparamref name="T"/> entered by the user, or the <paramref name="defaultValue"/> if no input is provided.
    /// </returns>
    public static T Get<T>(string prompt, T defaultValue) =>
        AnsiConsole.Prompt(
            new TextPrompt<T>($"[white]{prompt}[/]")
                .PromptStyle("white")
                .DefaultValueStyle(new(Color.Yellow))
                .DefaultValue(defaultValue)
                .ValidationErrorMessage("[white on red]Invalid entry![/]"));
}
