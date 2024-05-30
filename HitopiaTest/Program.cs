using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitopiaTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region WeightedString
            // test 1
            var input = new int[] { 1, 3, 9, 8 };
            var result = WeightedString.CheckQueries("abbcccd", input);
            Console.WriteLine(string.Join(",", result));

            // test 2
            input = new int[] { 5, 1, 4, 7 };
            result = WeightedString.CheckQueries("eadbbb", input);
            Console.WriteLine(string.Join(",", result));

            // test 3
            input = new int[] { 7, 12, 7, 23 };
            result = WeightedString.CheckQueries("rasta", input);
            Console.WriteLine(string.Join(",", result));
            #endregion

            #region BalancedBracket
            var expression = "{ [ ( ) ] }";
            Console.WriteLine(BalancedBracket.CheckBalancedBracket(expression));

            expression = "{ [ ( ] ) }";
            Console.WriteLine(BalancedBracket.CheckBalancedBracket(expression));

            expression = "{ ( ( [ ] ) [ ] ) [ ] }";
            Console.WriteLine(BalancedBracket.CheckBalancedBracket(expression));
            #endregion
        }
    }
}
