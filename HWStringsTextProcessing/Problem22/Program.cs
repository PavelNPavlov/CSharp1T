using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem22
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');

            var repetionCount = words.GroupBy(x => x)
                .Select(g => g.Count())
                .ToList();

            var wordsU = words.Distinct()
                .ToList();
            for (int i = 0; i < repetionCount.Count(); i++)
            {
                Console.WriteLine(" [{0}] is repeated {1} times!", wordsU[i], repetionCount[i]);
            }
            Console.WriteLine();
        }

        abstract
    }
}
