using System.Collections.Generic;

namespace VaildBracesTest
{
    public class VaildHelper
    {
        public bool VaildBraces(string input)
        {
            if (input.Length % 2 != 0)
            {
                return false;
            }
            var starIndex = 0;
            var endIndex = input.Length - 1;
            for (; starIndex < endIndex; starIndex++, endIndex--)
            {
                if (!CheckBraceIsMatch(input, starIndex, endIndex))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckBraceIsMatch(string input, int starIndex, int endIndex)
        {
            var Brace = new Dictionary<char, char>
            {
                { '[',']'},
                { '(',')'},
                { '{','}'}
            };
            return Brace[input[starIndex]] == input[endIndex];
        }
    }
}