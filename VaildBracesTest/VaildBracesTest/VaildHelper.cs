using System.Collections.Generic;
using NUnit.Framework;

namespace VaildBracesTest
{
    public class VaildHelper
    {
        private static readonly Dictionary<char, char> BracketsDictionary = new Dictionary<char, char>
        {
            { '[',']'},
            { '(',')'},
            { '{','}'}
        };


        public bool VaildBraces(string input)
        {
            if (LenIsNotVaild(input))
            {
                return false;
            }

            var bracketsStack = new List<char>();
            for (var index = 0; index < input.Length; index++)
            {
                AddFirstBracket(input, index, bracketsStack);
                RemoveMatchBraces(input, index, bracketsStack);
            }

            return bracketsStack.Count == 0;
        }

        private static void AddFirstBracket(string input, int i, List<char> stack)
        {
            if (BracketsDictionary.ContainsKey(input[i]))
            {
                stack.Add(input[i]);
            }
        }

        private static void RemoveMatchBraces(string input, int i, List<char> stack)
        {
            if (BracketsDictionary[stack[stack.Count - 1]] == input[i])
            {
                stack.RemoveAt(stack.Count - 1);
            }
        }

        private static bool LenIsNotVaild(string input)
        {
            return input.Length % 2 != 0;
        }
    }
}