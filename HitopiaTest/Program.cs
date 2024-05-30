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
            // test 1
            var input = new int[] { 1, 3, 9, 8 };
            var result = WeightedString.CheckQueries("abbcccd", input);
            Console.WriteLine(string.Join(",", result));
        }
    }
}
