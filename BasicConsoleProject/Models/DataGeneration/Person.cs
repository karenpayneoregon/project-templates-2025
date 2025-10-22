using BasicConsoleProject.Interfaces.DataGeneration;

namespace BasicConsoleProject.Models.DataGeneration;

public class Person : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string MiddleName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    public DateOnly BirthDate { get; set; }
    public string DriverLicense { get; set; } = string.Empty;
    public string SocialSecurityNumber { get; set; } = string.Empty;
    public Address? Address { get; set; }

}

