using AspCore2025.Models.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace AspCore2025.Classes.Configuration;

/// <summary>
/// Provides a set of static methods for validating application startup configurations.
/// </summary>
/// <remarks>
/// This class includes methods to validate and configure essential application settings,
/// such as SQL connection strings, during the startup process. These validations ensure
/// that the application is properly configured before it begins running.
///
/// 💡Even better is to have this code in a NuGet package so that it can be reused in other projects.
/// 
/// </remarks>
public static class StartupValidators
{

    /// <summary>
    /// Configures SQL connection validation for the application by binding the 
    /// <see cref="ConnectionStrings"/> section from the configuration and adding validation logic.
    /// </summary>
    /// <param name="services">
    /// The <see cref="IServiceCollection"/> to which the SQL connection validation services will be added.
    /// </param>
    /// <param name="configuration">
    /// The <see cref="IConfiguration"/> instance used to retrieve the application's configuration settings.
    /// </param>
    /// <returns>
    /// The updated <see cref="IServiceCollection"/> with SQL connection validation services registered.
    /// </returns>
    /// <remarks>
    /// This method binds the <see cref="ConnectionStrings"/> section from the application's configuration,
    /// validates it on startup, and registers the <see cref="SqlConnectionValidator"/> for additional validation logic.
    /// </remarks>
    public static IServiceCollection SqlConnectionValidation(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddOptions<ConnectionStrings>()
            .Bind(configuration.GetSection(nameof(ConnectionStrings)))
            .ValidateOnStart();

        services.AddSingleton<IValidateOptions<ConnectionStrings>, SqlConnectionValidator>();

        return services;
    }
}
