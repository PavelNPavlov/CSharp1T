using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10
{
    class UniCode
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            byte[] bytes = Encoding.Default.GetBytes(input);
            input = Encoding.UTF8.GetString(bytes);

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("\\u{0:X4}", (byte)input[i]);
            }
            Console.WriteLine();
        }
    }
}
