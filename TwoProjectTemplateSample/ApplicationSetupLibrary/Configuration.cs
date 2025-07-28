using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace $safeprojectname$;

/// <summary>
/// Provides methods to build and retrieve configuration settings from various sources, 
/// including JSON files, XML files, user secrets, environment variables, and command-line arguments.
/// </summary>
public class Configuration
{
    /// <summary>
    /// Builds and returns an <see cref="IConfigurationRoot"/> object configured to read settings 
    /// from the "appsettings.json" file and environment variables.
    /// </summary>
    /// <returns>
    /// An <see cref="IConfigurationRoot"/> object that provides access to configuration settings 
    /// from "appsettings.json" and environment variables.
    /// </returns>
    public static IConfigurationRoot JsonRoot() =>
        new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables()
            .Build();


    /// <summary>
    /// Builds and returns an <see cref="IConfigurationRoot"/> object configured to read settings from JSON files,
    /// user secrets, and environment variables.
    /// </summary>
    /// <remarks>
    /// This method reads configuration settings from the following sources:
    /// <list type="bullet">
    /// <item><description>The "appsettings.json" file.</description></item>
    /// <item><description>The "appsettings.{environment}.json" file, where <c>{environment}</c> is the value of the "NETCORE_ENVIRONMENT" environment variable.</description></item>
    /// <item><description>User secrets associated with the executing assembly.</description></item>
    /// <item><description>Environment variables.</description></item>
    /// </list>
    /// </remarks>
    /// <returns>
    /// An <see cref="IConfigurationRoot"/> object that provides access to the combined configuration settings from the specified sources.
    /// </returns>
    public static IConfigurationRoot JsonRootSecrets()
    {
        var environment = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT");
        return new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{environment}.json", optional: true)
            .AddUserSecrets(Assembly.GetExecutingAssembly(), true)
            .AddEnvironmentVariables()
            .Build();
    }
}