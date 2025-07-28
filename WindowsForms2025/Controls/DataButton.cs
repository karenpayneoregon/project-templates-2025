using System.ComponentModel;

#nullable disable

namespace WindowsForms2025.Controls;

/// <summary>
/// Represents a specialized button control with additional properties for identifier and stash.
/// </summary>
/// <remarks>
/// The <see cref="DataButton"/> class extends the functionality of a standard <see cref="Button"/> 
/// by introducing properties for managing an identifier and a stash value.
/// </remarks>
public class DataButton : Button
{
    [Category("Behavior"), Description("Identifier")]
    public int Identifier { get; set; }
    [Category("Behavior"), Description("Stash")]
    public string Stash { get; set; }
}
