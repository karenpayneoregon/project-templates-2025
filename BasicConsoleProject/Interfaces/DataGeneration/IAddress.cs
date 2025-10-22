namespace BasicConsoleProject.Interfaces.DataGeneration;

/// <summary>
/// Represents an address with properties for various address components such as street, city, state, and country.
/// </summary>
public interface IAddress
{
    int Id { get; set; }
    string Street { get; set; }
    string City { get; set; }
    string State { get; set; }
    string ZipCode { get; set; }
    string Country { get; set; }
}