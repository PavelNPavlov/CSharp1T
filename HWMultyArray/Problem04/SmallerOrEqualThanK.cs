using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class SmallerOrEqualThanK
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] data = input.Split(' ');
            int N = data.Length;
            int K = int.Parse(Console.ReadLine());

            int[] dataValue = new int[N];
            for (int i = 0; i < data.Length; i++)
            {
                dataValue[i] = int.Parse(data[i]);
            }

            Array.Sort(dataValue);
            int count = 0;
            int temp=0;
            while (true)
            {
                temp= Array.BinarySearch(dataValue,K-count);
                if (temp < 0) { count++; }
                else { break; }
              
            }

            //This would work only for integers since the step is constantly 1
            //Alternatively order values by difference from the search key

            Console.WriteLine(dataValue[temp]);
           
        }
    }
}
