using BasicConsoleProject.Interfaces.DataGeneration;

namespace BasicConsoleProject.Models.DataGeneration;

public class Address : IAddress
{
    public required int Id { get; set; }
    public required string Street { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public required string ZipCode { get; set; }
    public required string Country { get; set; }
}
