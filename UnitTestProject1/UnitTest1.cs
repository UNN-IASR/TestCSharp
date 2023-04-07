using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod()]
        [DeploymentItem("testFile1.xml")]
        public void ConstructorTest()
        {
            string file = "testFile1.xml";
            Assert.IsTrue(File.Exists(file), "deployment failed: " + file +
                " did not get deployed");
        }
        [TestMethod]
        public void TestMethod1()
        {
            int result = ConsoleApp1.Program.mul(3, 4);
            Assert.IsTrue(result == 12);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int result = ConsoleApp1.Program.add(3, 4);
            Assert.IsTrue(result == 7);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var asm = Assembly.GetExecutingAssembly();
            Assert.IsTrue(true);
        }
    }
}