using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace VaildBracesTest
{
    [TestFixture]
    public class VaildBracesTest
    {
        [TestCase("[", false, TestName = "input one char should return false")]
        [TestCase("[{", false, TestName = "input two char but not match braces should return false")]
        [TestCase("[{}]", true, TestName = "input  match braces [{}] should return true")]
        [TestCase("[{}][]", true, TestName = "input  match braces [{}][] should return true")]
        public void TestMethod1(string input, bool expected)
        {
            var result = new VaildHelper().VaildBraces(input);
            Assert.AreEqual(expected, result);
        }
    }
}
