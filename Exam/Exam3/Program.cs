using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            
            BigInteger sumProduct = 1;
            int countT = 0;

            N:
            while(true)
            {
                number /= 10;
                if(number==0)
                {
                    countT++;
                    break;
                    
                }
                int sumCurrent = 0;
                //int sumCount = 0;
                int l = (number.ToString()).Length;
                string numAsStr = number.ToString();
                for(int i=0; i<l; i++)
                {
                    if (i % 2 == 1)
                    {
                        char temp = numAsStr[i];
                        sumCurrent += (int)Char.GetNumericValue(temp);
                    }
                }

                if (sumCurrent != 0)
                {
                    sumProduct *= sumCurrent;
                }

            }

           
           if(sumProduct.ToString().Length==1 || countT==10)
           {
               if (countT != 10)
               {
                   Console.WriteLine(countT);
               }
               Console.WriteLine(sumProduct);
           }

           if(sumProduct.ToString().Length!=1 && countT<10 )
           {
               number = sumProduct;
               sumProduct = 1;
               goto N;
           }
        }
    }
}
