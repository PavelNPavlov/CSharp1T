using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            int testing = 5;
            var z = Convert.ToString(testing, 2);
            Console.WriteLine(z[3]);
        }
    }
}
