#nullable disable
namespace MsTest2025.Base
{
    /// <summary>
    /// Serves as a base class for MSTest test classes, providing shared functionality 
    /// such as managing the <see cref="TestContext"/> and storing test results.
    /// </summary>
    public class BaseConfiguration
    {
        protected TestContext TestContextInstance;
        public TestContext TestContext
        {
            get => TestContextInstance;
            set
            {
                TestContextInstance = value;
                TestResults.Add(TestContext);
            }
        }

        public static IList<TestContext> TestResults;
    }
}
