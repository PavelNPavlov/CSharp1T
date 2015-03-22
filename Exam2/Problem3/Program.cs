using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        
        static int locI = 0;
        static int locJ = 0;
        
        static void Main(string[] args)
        {
            //make matrix

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            long[,] matrix3 = new long[numbers[0], numbers[1]];
            locI = numbers[0]-1;
 
            //fill in matrix
            //bottom line
            for (int i = 0; i < matrix3.GetLength(1); i++)
            {
                matrix3[matrix3.GetLength(0) - 1, i] = i * 3;
            }

            //left line
            for (int i = matrix3.GetLength(0) - 2; i >=0; i--)
            {
                matrix3[i, 0] = (matrix3.GetLength(0) - 1-i) * 3;
            }

            //rest
            for (int i = 0; i < matrix3.GetLength(0)-1; i++)
            {
                for (int j = 1; j < matrix3.GetLength(1); j++)
                {
                    matrix3[i, j] = matrix3[i, 0] + matrix3[matrix3.GetLength(0) - 1, j];
                }
            }


            //for (int i = 0; i < matrix3.GetLongLength(0); i++)
            //{
            //    for (int j = 0; j < matrix3.GetLongLength(1); j++)
            //    {
            //        Console.Write(matrix3[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}


            string[] moves = new string[int.Parse(Console.ReadLine())];
            
            for (int i = 0; i < moves.Length; i++)
            {
                moves[i] = Console.ReadLine();
            }

            BigInteger sumC = 0;

            foreach (var item in moves)
            {
                string[] temp=item.Split(' ');
                for (int i = 0; i < int.Parse(temp[1]) ; i++)
                {
                    long oldj = locJ;
                    long oldi = locI;
                    if (i > 0)
                    {
                        Move(temp[0], matrix3);
                        if(oldi==locI)
                        {
                            break;
                        }
                    }
                    

                    BigInteger tempn = matrix3[locI, locJ];
                    sumC += tempn;
                    matrix3[locI, locJ] = 0;
                }
            }

            Console.WriteLine(sumC);

            

        }

        static void Move(string s,long[,] matrix)
        {
            switch(s)
            {
                case "RU":
                case "UR":
                    if (locI > 0 && locJ < matrix.GetLength(1)-1)
                    {
                        locI--;
                        locJ++;
                    }
                    break;

                case "LU":
                case "UL":
                    if (locI > 0 && locJ > 0)
                    {
                        locI--;
                        locJ--;
                    }
                    break;

                case "DL":
                case "LD":
                    if (locI <matrix.GetLength(0)-1 && locJ >0)
                    {
                        locI++;
                        locJ--;
                    }
                    break;

                case "DR":
                case "RD":
                    if (locI < matrix.GetLength(0)-1 && locJ < matrix.GetLength(1)-1)
                    {
                        locI++;
                        locJ++;
                    }
                    break;

            }           
            
        }

    }
}
