using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ArgiDUX\Desktop\DataBase.txt");
            foreach(string value in lines)
            {
                Console.WriteLine(value);
            }
        }
    }
}
