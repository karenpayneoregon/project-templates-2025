using ConsoleConfigurationLibrary.Classes;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ConsoleWithDapper2025.Classes;
internal class DataOperations
{
    private IDbConnection _cn = new SqlConnection(AppConnections.Instance.MainConnection);
}
