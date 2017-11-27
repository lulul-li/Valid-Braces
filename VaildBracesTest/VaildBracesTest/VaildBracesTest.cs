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
        [TestCase(")(}{][", false, TestName = "input  )(}{][ should return false")]
        [TestCase("())({}}{()][][", false, TestName = "input ())({}}{()][][ should return false")]
        public void VaildBracesReturnIsCorrect(string input, bool expected)
        {
            var result = new Brace(input).VaildBraces();
            Assert.AreEqual(expected, result);
        }
    }
}
