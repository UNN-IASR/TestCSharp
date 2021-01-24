using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int result=ConsoleApp1.Program.add(4, 5);
            Assert.IsTrue(result == 9);
        }
    }
}