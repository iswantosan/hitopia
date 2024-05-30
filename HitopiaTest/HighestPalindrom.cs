using System;
using System.Linq;

namespace HitopiaTest
{
    public class HighestPalindrom
    {
        public static string GetHighestPalindrom(string input, int k)
        {
            if (k < 0)
                return "-1";

            if (string.IsNullOrEmpty(input))
                return "-1";

            if (input.Length == 1)
                return input;

            if (IsPalindrome(input))
                return input;

            
            if (input[0] != input[input.Length - 1])
                return $"{Math.Max(input[0], input[input.Length - 1])}{GetHighestPalindrom(input.Substring(1, input.Length - 1), k - 1)}{Math.Max(input[0], input[input.Length - 1])}";

            return $"{input[0]}{GetHighestPalindrom(input.Substring(1, input.Length - 2), k)}{input[input.Length - 1]}";
        }


        public static bool IsPalindrome(string str)
        {
            if (str == null || str == "-1") return false;

            return str.Reverse().Equals(str);
        }
    }
}
