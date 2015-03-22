using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public struct Sum
    {
        public int indexR;
        public int indexC;
        public int sumS;

        public Sum(int r, int c, int sum)
        {
            indexR = r;
            indexC = c;
            sumS = sum;
        }

    }

    class Sums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];
            int subSize = 3;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("[{0},{1}] ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int maxSum = SubSum(0, 0, matrix, subSize);
            Sum maxSumStr = new Sum(0, 0, maxSum);
            for (int i = 0; i < n-subSize+1; i++)
            {
                for (int j = 0; j < m-subSize+1; j++)
                {
                    int temp=SubSum(i,j,matrix,subSize);
                    if (maxSum < temp)
                    {
                        maxSum = temp;
                        maxSumStr = new Sum(i, j, maxSum);
                    }
                }
            }

            Print(matrix);
            Console.WriteLine(maxSum);
            Console.WriteLine(maxSumStr.indexR + " " + maxSumStr.indexC);

        }

        static public int SubSum (int r, int c,int[,] a, int size)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sum += a[r + i, c + j];
                }
            }

            return sum;
        }

        static public void Print(int[,]a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
