using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    
    class MergeSort
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

                Merge_Recursion(data,0,data.Length-1);

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

        static public void doMerge(int[] numbers,int left, int mid, int right )
        {
            int[] temp = new int[50];
            int i, left_end, num_elements, tmp_pos;
            left_end = mid - 1;
            tmp_pos = left;
            num_elements = right - left + 1;

            while(left<=left_end && mid<=right)
            {
                if(numbers[left]<=numbers[mid])
                {
                    temp[tmp_pos++] = numbers[left++];
                }
                else
                {
                    temp[tmp_pos++] = numbers[mid++];
                }
            }

            while (left <= left_end)
            {
                temp[tmp_pos++] = numbers[left++];
            }

            while (mid <= right)
            {
                temp[tmp_pos++] = numbers[mid++];
            }

            for (i = 0; i < num_elements; i++)
            {

                numbers[right] = temp[right];
                right--;

            }
        }

        static public void Merge_Recursion(int[] numbers, int left, int right)
        {
            int mid;
            if(right>left)
            {
                mid = (right + left) / 2;
                Merge_Recursion(numbers, left, mid);
                Merge_Recursion(numbers, mid + 1, right);
                doMerge(numbers, left, mid + 1, right);
            }
        }
    }
}
