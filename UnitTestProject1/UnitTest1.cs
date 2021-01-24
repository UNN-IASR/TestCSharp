using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = ConsoleApp1.Program.mul(3, 4);
            Assert.IsTrue(result == 12);
        }
                [TestMethod]
        public void TestMethod2()
        {
            int result = ConsoleApp1.Program.sum(3, 4);
            Assert.IsTrue(result == 7);
        }
    }
}