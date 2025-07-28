
// ReSharper disable once CheckNamespace
namespace MsTest2025;

public partial class Test1
{
    [TestInitialize]
    public void Initialization() { }

    [ClassInitialize()]
    public static void ClassInitialize(TestContext testContext)
    {
        TestResults = new List<TestContext>();
    }
}