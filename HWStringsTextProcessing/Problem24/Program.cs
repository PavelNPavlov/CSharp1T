using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem24
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');

            Array.Sort(words);

            foreach (var item in words)
            {
                Console.Write(item + " ");
            }
        }
    }
}
