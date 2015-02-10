using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            int p = 0;
            string r = "";

            int bit = (3 >> 0) & 1;
            r = bit.ToString() + r;

            bit = (3 >> 1) & 1;
            r = bit.ToString() + r;

            Console.WriteLine(r);
            
        }
    }
}
