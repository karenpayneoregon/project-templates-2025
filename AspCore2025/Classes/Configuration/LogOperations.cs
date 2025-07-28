using Serilog;
using Serilog.Events;

// Ensure this is included for Log.Logger and LoggerConfiguration

// Ensure this is included for LogEventLevel
namespace AspCore2025.Classes.Configuration;

/// <summary>
/// Provides operations for configuring Serilog logging in an ASP.NET Core application.
/// </summary>
/// <remarks>
/// This class includes methods to set up logging configurations tailored to different environments.
/// For development environments, logs are written to the console with a minimum log level of Information.
/// For non-development environments, logs are written to a file with a rolling interval.
/// </remarks>
public static class LogOperations
{
    /// <summary>
    /// Configures Serilog logging for the application based on the current environment.
    /// </summary>
    /// <param name="builder">
    /// The <see cref="WebApplicationBuilder"/> instance used to configure the application's services and middleware.
    /// </param>
    /// <remarks>
    /// In a development environment:
    /// Logs are written to the console with a minimum log level of Information.
    /// 
    /// In a non-development environment:
    /// Logs are written to a file located in the "LogFiles" directory, with a rolling interval and a detailed output template.
    /// 
    /// This method ensures that the application's logging configuration is tailored to the environment, 
    /// improving the ability to monitor and debug the application.
    /// </remarks>
    public static void SetupSerilog(this WebApplicationBuilder builder)
    {

        if (builder.Environment.IsDevelopment())
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("System", LogEventLevel.Warning)
                .MinimumLevel.Information()
                .WriteTo.Console()
                .CreateLogger();
        }
        else
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("System", LogEventLevel.Warning)
                .MinimumLevel.Information()
                .WriteTo.File(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LogFiles",
                        $"{DateTime.Now.Year}-{DateTime.Now.Month:d2}-{DateTime.Now.Day:d2}", "Log.txt"),
                    rollingInterval: RollingInterval.Infinite,
                    outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level}] {Message}{NewLine}{Exception}")
                .CreateLogger();

        }

        builder.Host.UseSerilog();
    }
}
