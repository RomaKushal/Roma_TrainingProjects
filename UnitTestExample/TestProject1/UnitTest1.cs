using NUnit.Framework;
using System;
using System.IO;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        private const string Expected = "Hello World!";

        [Test]
        public void Test1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}