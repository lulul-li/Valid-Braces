using System;
using NUnit.Framework;

namespace VaildBracesTest
{
    [TestFixture]
    public class VaildBracesTest
    {
        [TestCase("[",false,TestName = "input one char should return false")]
        [TestCase("[{", false, TestName = "input two char but not match braces should return false")]
        [TestCase("[{}]", true, TestName = "input  match braces [{}] should return true")]
        public void TestMethod1(string input, bool expected)
        {
            var result = VaildBraces(input);
            Assert.AreEqual(expected, result);
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
