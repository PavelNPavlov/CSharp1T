using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class TenRands
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rng.Next(100,200));
            }
        }
    }
}
