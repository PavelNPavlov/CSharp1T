using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9
{
    class Mode
    {
        static void Main(string[] args)
        {
        Start:
            try
            {
                //Console.WriteLine("Enter size of arrays");
                string input = Console.ReadLine();

                string[] inputS = input.Split(',');

                int[] data = new int[inputS.Length];

                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = int.Parse(inputS[i]);
                }
                int sum = 0;
                
                int mode = data
                    .GroupBy(x => x)
                    .OrderByDescending(g => g.Count())
                    .First() // throws InvalidOperationException if myArray is empty
                    .Key;
                int count = 0;
                foreach(int value in data)
                {
                    if (value == mode) { count++; }
                }

                Console.WriteLine("{0} ({1} times)",mode,count);
            }

            catch (FormatException)
            {
                Console.WriteLine("Incorrect input format");
            }
            Console.WriteLine();
            Console.WriteLine("If you wish to continue press [y].");
            if (Console.ReadLine() == "y") { goto Start; }
        }
    }
}
