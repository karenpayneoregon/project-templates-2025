﻿using ConsoleConfigurationLibrary.Classes;

namespace BasicConsoleProject.Classes.Other;
/// <summary>
/// Performs data operations.
/// </summary>
internal class DataOperations
{
    // here for demonstration purposes
    public static void GetSettings()
    {
        Console.WriteLine(AppConnections.Instance.MainConnection);
        Console.WriteLine(EntitySettings.Instance.CreateNew);
    }
}
