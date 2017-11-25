using System;
using NUnit.Framework;

namespace VaildBracesTest
{
    [TestFixture]
    public class VaildBracesTest
    {
        [TestCase("[",TestName = "input one char should return false")]
        [TestCase("[{",TestName = "input not match braces should return false")]
        public void TestMethod1(string input)
        {
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
