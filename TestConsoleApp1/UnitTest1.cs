namespace TestConsoleApp1;

using System.Security.Cryptography.X509Certificates;
using MyConsoleApp;
[TestClass]
public class UnitTest1
{
    private readonly App myApp;

    public UnitTest1()
    {
        myApp = new App();
    }
    [TestMethod]
    public void TestMethod1()
    {
        bool result = myApp.IsPositive(1);
        Assert.IsTrue(result, "NOT PASSED!");
    }
}