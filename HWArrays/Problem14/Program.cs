using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Start:
            try
            {
                //Console.WriteLine("Enter size of arrays");
                string input = Console.ReadLine();

                string[] inputS = input.Split(',');

                int[] data = new int[inputS.Length];

                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = int.Parse(inputS[i]);
                }

               Quicksort(data,0,data.Length-1);

                foreach(int value in data)
                {
                    Console.Write(value+" ");
                }
                
            }

            catch (FormatException)
            {
                Console.WriteLine("Incorrect input format");
            }

            Console.WriteLine("If you wish to continue press [y].");
            if (Console.ReadLine() == "y") { goto Start; }
        }

        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                   int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}
