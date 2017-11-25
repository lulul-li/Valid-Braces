using System;
using NUnit.Framework;

namespace VaildBracesTest
{
    [TestFixture]
    public class VaildBracesTest
    {
        [TestCase("[",TestName = "input one char should return false")]
        [TestCase("[{",TestName = "input two char but not match braces should return false")]
        public void TestMethod1(string input)
        {
            var result = VaildBraces(input);
            Assert.AreEqual(false, result);
        }

        public bool VaildBraces(string input)
        {
            for (var i = 0; i < input.Length-1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
