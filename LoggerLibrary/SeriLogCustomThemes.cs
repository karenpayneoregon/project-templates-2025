using Serilog.Sinks.SystemConsole.Themes;

namespace LoggerLibrary;

/// <summary>
/// Feel free to change the colors
/// </summary>
public class SeriLogCustomThemes
{

    /// <summary>
    /// Creates a custom console theme named "KarenConsoleTheme" with the following styles:
    /// <br/>- <b>Text:</b> Green
    /// <br/>- <b>String:</b> Yellow
    /// <br/>- <b>Number:</b> Cyan
    /// <br/>- <b>Boolean:</b> Red
    /// <br/>- <b>Error:</b> Red on Yellow
    /// <br/>- <b>Verbose Level:</b> Green
    /// <br/>- <b>Information Level:</b> Dark Cyan
    /// <br/>- <b>Secondary Text:</b> White on Dark Blue
    /// </summary>
    /// <returns>A <see cref="SystemConsoleTheme"/> instance configured with the specified styles.</returns>
    public static SystemConsoleTheme KarenConsoleTheme() =>
        new(new Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle>()
        {
            { ConsoleThemeStyle.Text, new SystemConsoleThemeStyle { Foreground = ConsoleColor.Green, } },
            { ConsoleThemeStyle.LevelVerbose, new SystemConsoleThemeStyle { Foreground = ConsoleColor.Green, } },
            { ConsoleThemeStyle.String, new SystemConsoleThemeStyle { Foreground = ConsoleColor.Yellow, } },
            { ConsoleThemeStyle.Number, new SystemConsoleThemeStyle { Foreground = ConsoleColor.Cyan, } },
            { ConsoleThemeStyle.Boolean, new SystemConsoleThemeStyle { Foreground = ConsoleColor.Red, } },
            { ConsoleThemeStyle.LevelInformation, new SystemConsoleThemeStyle { Foreground = ConsoleColor.DarkCyan, } },
            { ConsoleThemeStyle.SecondaryText, new SystemConsoleThemeStyle { Foreground = ConsoleColor.White, Background = ConsoleColor.DarkBlue, } },
            { ConsoleThemeStyle.LevelError, new SystemConsoleThemeStyle { Foreground = ConsoleColor.Red, Background = ConsoleColor.Yellow, } }
        });

    /// <summary>
    /// Custom theme with the following styles:<br/>
    /// Text: Blue<br/>
    /// String: Yellow<br/>
    /// Number: Cyan<br/>
    /// Boolean: White<br/>
    /// Level Information: Dark Green
    /// </summary>
    /// <returns>A <see cref="SystemConsoleTheme"/> instance configured with the specified styles.</returns>
    public static SystemConsoleTheme Theme2()
    {
        Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> customThemeStyles =
            new()
            {
                {
                    ConsoleThemeStyle.Text, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Blue,
                    }
                },
                {
                    ConsoleThemeStyle.String, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Yellow,
                    }
                },
                {
                    ConsoleThemeStyle.Number, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Cyan,
                    }
                },
                {
                    ConsoleThemeStyle.Boolean, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White,
                    }
                },
                {
                    ConsoleThemeStyle.LevelInformation, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.DarkGreen
                    }
                }
            };

        return new SystemConsoleTheme(customThemeStyles);

    }

    /// <summary>
    /// Custom theme with the following styles:<br/>
    /// Text: Green<br/>
    /// String: Cyan<br/>
    /// Number: Yellow<br/>
    /// Boolean: White<br/>
    /// </summary>
    /// <returns>A <see cref="SystemConsoleTheme"/> instance configured with the specified styles.</returns>
    public static SystemConsoleTheme Theme3()
    {
        Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> customThemeStyles =
            new()
            {
                {
                    ConsoleThemeStyle.Text, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Green,
                    }
                },
                {
                    ConsoleThemeStyle.String, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Cyan
                    }
                },
                {
                    ConsoleThemeStyle.Number, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Yellow,
                    }
                },
                {
                    ConsoleThemeStyle.Boolean, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White,
                    }
                },
            };

        return new SystemConsoleTheme(customThemeStyles);

    }

    /// <summary>
    /// Creates a custom JSON-themed console theme for Serilog logging.
    /// </summary>
    /// <remarks>
    /// The theme defines the following styles:
    /// <list type="bullet">
    /// <item><description><b>Text:</b> Green</description></item>
    /// <item><description><b>String:</b> Dark Cyan</description></item>
    /// <item><description><b>Number:</b> Cyan</description></item>
    /// <item><description><b>Boolean:</b> White</description></item>
    /// <item><description><b>Level Information:</b> Dark Green</description></item>
    /// </list>
    /// </remarks>
    /// <returns>
    /// A <see cref="SystemConsoleTheme"/> instance configured with the specified styles.
    /// </returns>
    public static SystemConsoleTheme JsonTheme()
    {
        Dictionary<ConsoleThemeStyle, SystemConsoleThemeStyle> customThemeStyles =
            new()
            {
                {
                    ConsoleThemeStyle.Text, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Green,
                    }
                },
                {
                    ConsoleThemeStyle.String, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.DarkCyan,
                    }
                },
                {
                    ConsoleThemeStyle.Number, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.Cyan,
                    }
                },
                {
                    ConsoleThemeStyle.Boolean, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.White,
                    }
                },
                {
                    ConsoleThemeStyle.LevelInformation, new SystemConsoleThemeStyle
                    {
                        Foreground = ConsoleColor.DarkGreen
                    }
                }
            };

        return new SystemConsoleTheme(customThemeStyles);

    }
}
