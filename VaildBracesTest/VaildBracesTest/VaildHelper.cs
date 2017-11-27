using System.Collections.Generic;

namespace VaildBracesTest
{
    public class VaildHelper
    {
        public bool VaildBraces(string input)
        {
            if (LenIsNotVaild(input))
            {
                return false;
            }
            
            var starIndex = 0;
            var endIndex = input.Length - 1;
            for (; starIndex < endIndex; starIndex++, endIndex--)
            {
                if (!BraceIsMatch(input, starIndex, endIndex))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool LenIsNotVaild(string input)
        {
            return input.Length % 2 != 0;
        }

        private static bool BraceIsMatch(string input, int starIndex, int endIndex)
        {
            var braces = new Dictionary<char, char>
            {
                { '[',']'},
                { '(',')'},
                { '{','}'}
            };
            return braces[input[starIndex]] == input[endIndex];
        }
    }
}