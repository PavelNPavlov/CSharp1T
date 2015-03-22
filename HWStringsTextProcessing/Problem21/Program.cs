using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem21
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] letters = text.ToCharArray();

            var repetionCount = letters.GroupBy(x => x)
                .Select(g =>g.Count())
                .ToList();

            var symbol = letters.Distinct()
                .ToList();
            for (int i = 0; i < repetionCount.Count(); i++)
            {
                Console.WriteLine("{0} is repeated {1} times",symbol[i],repetionCount[i]);
            }
            Console.WriteLine();
        }
    }
}
