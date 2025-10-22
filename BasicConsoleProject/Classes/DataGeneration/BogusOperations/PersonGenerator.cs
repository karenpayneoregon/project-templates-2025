using BasicConsoleProject.Models.DataGeneration;
using Bogus;
using Bogus.DataSets;
using static System.DateTime;
using Person = BasicConsoleProject.Models.DataGeneration.Person;

namespace BasicConsoleProject.Classes.DataGeneration.BogusOperations;

/// <summary>
/// Provides functionality for generating a collection of <see cref="Person"/> objects 
/// with randomized data using the Bogus library.
/// </summary>
/// <remarks>
/// This class utilizes the <see cref="Faker{T}"/> class from the Bogus library to 
/// generate realistic data for <see cref="Person"/> objects, including properties 
/// such as names, birthdates, addresses, and more.
/// </remarks>
public class PersonGenerator
{
    /// <summary>
    /// Generates a collection of <see cref="Person"/> objects with randomized data.
    /// </summary>
    /// <param name="count">
    /// The number of <see cref="Person"/> objects to generate. Defaults to 20 if not specified.
    /// </param>
    /// <returns>
    /// A list of <see cref="Person"/> objects populated with realistic, randomized data.
    /// </returns>
    /// <remarks>
    /// This method uses the Bogus library to generate realistic data for each <see cref="Person"/> object.
    /// The generated data includes properties such as names, gender, birthdates, addresses, and more.
    /// </remarks>
    public static List<Person> Create(int count = 3)
    {
        var id = 1;

        Randomizer.Seed = new Random(337);

        var faker = new Faker<Person>()
            .RuleFor(p => p.Id, f => id++)
            .RuleFor(p => p.Gender, f => f.PickRandom<Gender>())
            .RuleFor(p => p.FirstName, (f, p) =>
                p.Gender == Gender.Male
                    ? f.Name.FirstName(Name.Gender.Male)
                    : f.Name.FirstName(Name.Gender.Female))
            .RuleFor(p => p.MiddleName, (f, p) =>
                p.Gender == Gender.Male
                    ? f.Name.FirstName(Name.Gender.Male)
                    : f.Name.FirstName(Name.Gender.Female))
            .RuleFor(p => p.LastName, f => f.Name.LastName())
            .RuleFor(p => p.BirthDate, f => DateOnly.FromDateTime(f.Date.Past(60, Today.AddYears(-18))))
            .RuleFor(p => p.DriverLicense, f => f.Random.Replace("??######"))
            .RuleFor(p => p.SocialSecurityNumber, f => f.Random.Replace("###-##-####"))
            .RuleFor(p => p.Address, f => AddressGenerator.Create(1).FirstOrDefault());

        var people = faker.Generate(count);

        for (var index = 0; index < people.Count; index++)
        {
            people[index].Address!.Id = index + 1;
        }
        
        return people;
    }

}

