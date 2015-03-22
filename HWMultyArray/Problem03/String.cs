using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
   
    
    class String
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, m];
            int subSize = 3;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("[{0},{1}] ", i, j);
                    matrix[i, j] = Console.ReadLine();
                }
            }
            int max = 1;
            string maxString = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(SearchForSequence(i,j,matrix)>max)
                    {
                        max = SearchForSequence(i, j, matrix);
                        maxString = matrix[i, j];
                    }
                }
            }

            Print(matrix);

            Console.WriteLine(string.Concat(Enumerable.Repeat(maxString+" ", max)));



            
        }

        static public int SearchForSequence(int r, int c, string[,] a)
        {
            int count = 0;
            int countR = 1;
            int countC = 1;
            int countD = 1;
            
            int limit= a.GetLength(0)>a.GetLength(1)? a.GetLength(0):a.GetLength(1);

            for (int i = 0; i <limit ; i++)
            {
                if(r+countR<=a.GetLength(0)-1)
                {
                    if(a[r,c]==a[r+countR,c])
                    {
                        countR++;
                    }
                }
                if (c + countC <= a.GetLength(1) - 1)
                {
                    if (a[r, c] == a[r, c+countC])
                    {
                        countC++;
                    }
                }
                if(r+countD<=a.GetLength(0)-1 && c+countC<=a.GetLength(1)-1)
                {
                    if(a[r,c]==a[r+countD,c+countD])
                    {
                        countD++;
                    }
                }
            }

            return Math.Max(Math.Max(countR, countC), countD);
        }

        static public void Print(string[,] a)
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
