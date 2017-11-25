using System;
using NUnit.Framework;

namespace VaildBracesTest
{
    [TestFixture]
    public class VaildBracesTest
    {
        [Test]
        public void TestMethod1()
        {
            var input = "[";
            var result = VaildBraces(input);
            Assert.AreEqual(false, result);
        }

        private bool VaildBraces(string input)
        {
            if (input.Length < 2)
            {
                return false;
            }
            return true;
        }
    }
}
