using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World! by Jenkins";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ForJnk29.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
