using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWMultyArray
{
    class matrixCreate
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            //Matrix 1
            int [,] matrix=new int[n,n];
            int count=0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    count++;
                    matrix[j, i] = count;
                }
            }
            
            //matrix 2
            int[,] matrix2 = new int[n, n];
            int count2 = 0;
            int direction = 1;
            for (int i = 0; i < n; i++)
            {
                if (direction == 1)
                {
                    for (int j = 0; j < n; j++)
                    {
                        count2++;
                        matrix2[j, i] = count2;
                    }
                    direction = 2;
                    
                }
                else
                {   
                    
                    for (int j = n-1; j >= 0; j--)
                    {
                        count2++;
                        matrix2[j, i] = count2;
                    }
                    direction = 1;
                }
            }
            //Matrix 3

            int[,] matrix3 = new int[n, n];
            int count3 = 1;

            int r = n - 1;
            int c = 0;
            int countTemp = 0;
            while (count3<=n*n)
            {
                
                int tempR = r+countTemp;
                int tempC = c + countTemp;
                
                matrix3[tempR, tempC] = count3;
                count3++;
                countTemp++;
                if(tempR+1>n-1 && r!=0)
                {
                    r--;
                    countTemp = 0;
                }
                if(tempC+1>n-1 && r==0)
                {
                    c++;
                    countTemp = 0;
                }
            }

            //matrix 4

            int[,] matrix4 = new int[n, n];
            int count4 = 1;
            int direc = 1;
            r = 0;
            c = 0;
            int adj = 0;
            while (true)
            {
                matrix4[r, c] = count4;
                count4++;
            temp:
                if (count4 >= n * n+1) { break; } //prevents uneding cycle which would be casue by the goto temp logic. 
                if(direc==1 && r<n-1 && matrix4[r+1,c]==0)
                {
                    r++;
                    continue; //breaks cycle and do not keep preforming checks. 
                }
                else
                {
                    direc=2;
                    
                }

                if (direc == 2 && c < n - 1 && matrix4[r, c+1] == 0)
                {
                   c++;
                   continue;
                   
                }
                else
                {
                    direc = 3;
                    
                }

                if (direc == 3 && r > 0 && matrix4[r -1, c] == 0)
                {
                    r--;
                    continue;
                    
                }
                else
                {
                    direc = 4;
                    
                }

                if (direc == 4 && c > 0 && matrix4[r, c-1] == 0)
                {
                    c--;
                    continue;
                    
                }
                else
                {
                    direc = 1;
                    goto temp; //avoid overwriting one value and hence has 0 zero in the matrix and one value missing. 
                    
                }

            }

            printArray(matrix, n);
            printArray(matrix2, n);
            printArray(matrix3, n);
            printArray(matrix4, n);
        }
        
        
        static public void printArray(int[,] a,int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
