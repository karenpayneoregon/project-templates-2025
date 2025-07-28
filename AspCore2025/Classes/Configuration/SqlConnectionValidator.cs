using AspCore2025.Models.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace AspCore2025.Classes.Configuration;

/// <summary>
/// Provides validation logic for <see cref="ConnectionStrings"/> to ensure that the
/// <c>MainConnection</c> string is properly configured and a connection to the SQL database
/// can be successfully established.
/// </summary>
/// <remarks>
/// This validator checks that the <c>MainConnection</c> string is not null, empty, or whitespace.
/// Additionally, it attempts to establish a connection to the SQL database using the provided
/// connection string to verify its validity.
/// </remarks>
public class SqlConnectionValidator : IValidateOptions<ConnectionStrings>
{
    public ValidateOptionsResult Validate(string? name, ConnectionStrings options)
    {

        if (options == null || string.IsNullOrWhiteSpace(options.DefaultConnection))
        {
            return ValidateOptionsResult.Fail($"The '{nameof(ConnectionStrings)}' section is missing or not configured.");
        }

        if (string.IsNullOrWhiteSpace(options.DefaultConnection))
        {
            return ValidateOptionsResult.Fail($"{nameof(ConnectionStrings.DefaultConnection)} string cannot be empty.");
        }

        try
        {
            /*
             * We want a short timeout for the connection attempt to avoid blocking the application
             */
            var builder = new SqlConnectionStringBuilder(options.DefaultConnection)
            {
                ConnectTimeout = 2 
            };

            using var connection = new SqlConnection(builder.ConnectionString);

            connection.Open();
            connection.Close();

        }
        catch (Exception ex)
        {
            return ValidateOptionsResult.Fail($"Failed to open SQL connection: {ex.Message}");
        }

        return ValidateOptionsResult.Success;
    }
}
