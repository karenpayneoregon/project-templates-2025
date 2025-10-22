using BasicConsoleProject.Models.DataGeneration;

namespace BasicConsoleProject.Interfaces.DataGeneration;
/// <summary>
/// Represents a person with basic identifying information, including name, gender, birthdate, 
/// and social security number.
/// </summary>
public interface IPerson
{
    string FirstName { get; set; }
    string MiddleName { get; set; }
    string LastName { get; set; }
    Gender Gender { get; set; }
    DateOnly BirthDate { get; set; }
    string SocialSecurityNumber { get; set; }
}