using System.Xml.Linq;

namespace ProjectFrameworkUpdater;

public static class TargetFrameworkUpdater
{
    private const string OldFramework = "net9.0";
    private const string NewFramework = "net10.0";

    public static void Update(string rootFolder)
    {
        if (!Directory.Exists(rootFolder))
        {
            throw new DirectoryNotFoundException(
                $"Folder not found: {rootFolder}");
        }

        foreach (var projectFile in Directory.EnumerateFiles(
                     rootFolder,
                     "*.csproj",
                     SearchOption.AllDirectories))
        {
            UpdateProject(projectFile);
        }
    }

    private static void UpdateProject(string projectFile)
    {
        try
        {
            var document = XDocument.Load(projectFile, LoadOptions.PreserveWhitespace);

            var targetFrameworks = document
                .Descendants()
                .Where(element =>
                    element.Name.LocalName == "TargetFramework" &&
                    element.Value.Trim() == OldFramework)
                .ToList();

            if (targetFrameworks.Count == 0)
            {
                Console.WriteLine($"Skipped: {projectFile}");
                return;
            }

            foreach (var targetFramework in targetFrameworks)
            {
                targetFramework.Value = NewFramework;
            }

            document.Save(projectFile, SaveOptions.DisableFormatting);

            Console.WriteLine($"Updated: {projectFile}");
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Error processing {projectFile}: {exception.Message}");
        }
    }
}