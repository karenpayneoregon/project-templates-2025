using BasicConsoleProject.Classes.Configuration;

namespace BasicConsoleProject.Classes.DataGeneration.BogusOperations;
internal class GeneratePeople
{
    public static void Run()
    {
        
        SpectreConsoleHelpers.PrintCyan();
        
        var people = PersonGenerator.Create();

        foreach (var person in people)
        {
            Console.WriteLine($"{person.Id,-5}{person.FirstName,-20}{person.LastName,-20}{person.Gender}");
            if (person.Address is not null)
            {
                Console.WriteLine($"\t{person.Address.Street,-25}{person.Address.City,-30}{person.Address.State,-20}{person.Address.ZipCode}");
                Console.WriteLine(new string('-', 120));
            }

        }
    }
}
