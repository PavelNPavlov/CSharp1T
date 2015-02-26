using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            Console.WriteLine("{0,-15:d}{0,-15:X}{0,-15:0.00%}{0,-15:E2}", number);
        }
    }
}
