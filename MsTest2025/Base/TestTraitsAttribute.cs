using static System.Enum;

namespace MsTest2025.Base;

public enum Trait
{
    Default,
    Strings,
    Numbers
}
/// <summary>
/// Declarative class for using Trait enum about for traits on test method.
/// </summary>
public class TestTraitsAttribute : TestCategoryBaseAttribute
{
    private readonly Trait[] _traits;

    public TestTraitsAttribute(params Trait[] traits)
    {
        _traits = traits;
    }

    public override IList<string> TestCategories
    {
        get
        {
            var result = new string[_traits.Length];
            for (int i = 0; i < _traits.Length; i++)
            {
                result[i] = GetName(_traits[i]) ?? string.Empty;
            }
            return result;
        }
    }
}