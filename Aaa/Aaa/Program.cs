using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aaa
{
    class Program
    {
        static void Main(string[] args)
        {
            //read input

            int symbolsCount = int.Parse(Console.ReadLine());
            List<string> symbols = new List<string>();

            for (int i = 0; i < symbolsCount; i++)
			{
                symbols.Add(Console.ReadLine());
			}

            var repetionCount = symbols.GroupBy(x => x)
                .Select(g => g.Count())
                .ToList();

            var symbolU = symbols.Distinct()
                .ToList();

            Console.WriteLine();

            for (int i = 0; i < repetionCount.Count; i++)
            {
                Console.WriteLine("{0}  {1}",symbolU[i],repetionCount[i]);
            }
        }
    }
}
