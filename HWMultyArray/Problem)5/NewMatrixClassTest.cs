using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class StringLengh
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] data = input.Split(' ');


            IEnumerable<string> dataOrdered= data.OrderBy(x => x.Length);
            
            foreach(string value in dataOrdered)
            {
                Console.WriteLine(value);
            }

        }
    }
}
