using System.Collections.Generic;

namespace HitopiaTest
{
    public static class BalancedBracket
    {
        public static string CheckBalancedBracket(string input)
        {
            Stack<char> chars = new Stack<char>();
            Dictionary<char, char> pairs = new Dictionary<char, char>
            {
                {'(', ')'},
                {'{', '}'},
                {'[', ']'}
            };

            foreach (char c in input)
            {
                if (pairs.ContainsKey(c))
                {
                    chars.Push(c);
                }
                else if (pairs.ContainsValue(c))
                {
                    if (chars.Count == 0 || pairs[chars.Pop()] != c)
                    {
                        return Const.NO;
                    }
                }
            }

            return chars.Count == 0 ? Const.YES : Const.NO;
        }
    }
}
