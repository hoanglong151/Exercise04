using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca;

namespace sa
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(true, result4);
        }
    }
}
