using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace VaildBracesTest
{
    public class Brace
    {
        private static readonly Dictionary<char, char> BracketsDictionary = new Dictionary<char, char>
        {
            { '[',']'},
            { '(',')'},
            { '{','}'}
        };

        private static string _input;

        public Brace(string input)
        {
            _input = input;
        }


        public bool VaildBraces()
        {
            if (LenIsNotVaild())
            {
                return false;
            }

            var bracketsStack = new Stack<char>();
            for (var index = 0; index < _input.Length; index++)
            {
                AddFirstBracket(index, bracketsStack);
                RemoveMatchBraces(index, bracketsStack);
            }

            return bracketsStack.Count == 0;
        }

        private static void AddFirstBracket(int i, Stack<char> stack)
        {
            if (BracketsDictionary.ContainsKey(_input[i]))
            {
                stack.Push(_input[i]);
            }
        }

        private static void RemoveMatchBraces(int i, Stack<char> stack)
        {
            if (stack.Any() && BracketsDictionary[stack.Peek()] == _input[i])
            {
                stack.Pop();
            }
        }

        private static bool LenIsNotVaild()
        {
            return _input.Length % 2 != 0;
        }
    }
}