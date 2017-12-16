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
            foreach (char i in _input)
            {
                if (BracketsDictionary.ContainsKey(i))
                {
                    bracketsStack.Push(i);
                }
                else if (bracketsStack.Any() && BracketsDictionary[bracketsStack.Peek()] == i)
                {
                    bracketsStack.Pop();
                }
            }

            return bracketsStack.Count == 0;
        }

        private static bool LenIsNotVaild()
        {
            return _input.Length % 2 != 0;
        }
    }
}