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
            string catNumber = Console.ReadLine();

            string[] catNS = catNumber.Split(' ');

            long sum = 0;

            foreach (var item in catNS)
            {
                sum += CatToDecimal(item);
            }

            

            Console.WriteLine("{0} = {1}", DecimalCat(sum),sum);

            
        }

        static long CatToDecimal(string s)
        {
            long result=0;
            char[] letterNumbers = s.ToCharArray();

            Array.Reverse(letterNumbers);

            for (int i = 0; i < letterNumbers.Length; i++)
            {
                double tem=((int)letterNumbers[i]-(int)'a')*Math.Pow(23,i);
                result += (long) tem;
            }


            return result;

        }


        static string DecimalCat(long n)
        {
            string result = "";

            long temp = n;

             do
             {
                 long t = temp % 23;
                 char tempChar = (char)((int)t + (int)'a');
                 result = tempChar.ToString() + result;
                 temp /= 23;
                 
             } while (temp!=0);

            

            return result;
        }
    }
}
