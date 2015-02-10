using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            long result = 0;

            for(int i=0;i<input.Length;i++)
            {
                if(input[i]=='@')
                {
                    break;
                }

                char currentS = input[i];

                if (Char.IsDigit(currentS))
                {
                    int temp = (int)Char.GetNumericValue(currentS);
                    result *= temp;
                }

               else if(currentS>'a' && currentS<'z')
               {
                   int temp1= (int)currentS - (int)'a';
                   result += temp1;
               }

               else if (currentS > 'A' && currentS < 'Z')
               {
                   int temp1 = (int)currentS - (int)'A';
                   result += temp1;
               }

               else
               {
                   result = result % M;
               }
            }
            Console.WriteLine(result);

        }
    }
}
