using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    class Matrix
    {
        public int[,] body;
        public int n;
        public int m;

        public Matrix(int[,] a)
        {
            n = a.GetLength(0);
            m = a.GetLength(1);
            body = (int[,])a.Clone();
        }
        public Matrix MultiplyByNymber(int number)
        {
            int[,] temp = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    temp[i, j] = this.ValueAtIndexPrograming(i, j) * number;
                }
            }
            return new Matrix(temp);
        }

        public Matrix Add(Matrix a)
        {
            int[,] temp = new int[n, m];
            if (this.sumCheck(a) == false)
            {
                Console.WriteLine("Matrix missmatch. Sum is undefined in matemathical sense");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        temp[i, j] = this.ValueAtIndexPrograming(i, j) + a.ValueAtIndexPrograming(i, j);
                    }
                }
            }
            return new Matrix(temp);
        }
        public Matrix Subtract(Matrix a)
        {
            return this.Add(a.MultiplyByNymber(-1));
        }
        public Matrix Multiply(Matrix a)
        {
            int[,] temp = new int[n,m];
            if(this.MultyCheck(a)==false)
            {
                Console.WriteLine("Two object cant be multiplieyd");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    temp[i, j] = 0;
                    for (int k = 0; k < m; k++)
                    {
                        temp[i,j] += this.ValueAtIndexPrograming(i,k)*a.ValueAtIndexPrograming(k,j);
                    }
                }
            }
            return new Matrix(temp);
        }

        static public Matrix operator+(Matrix a, Matrix b)
        {
            return a.Add(b);
        }
        static public Matrix operator-(Matrix a,Matrix b)
        {
            return a.Subtract(b);
        }
        static public Matrix operator *(Matrix a, Matrix b)
        {
            return a.Multiply(b);
        }
        public object this[int i, int j]
        {
            get { return body[i, j]; }
            set { body[i, j] = (int)value; }

        }
        public int ValueAtIndexPrograming(int ni, int mi)
        {
            return this.body[ni, mi];
        }

        public bool sumCheck(Matrix a)
        {
            if (a.n == this.n && a.m == this.m) { return true; }
            else { return false; }
        }

        public bool MultyCheck(Matrix a)
        {
            if (a.m == this.n) { return true; }
            else { return false; }
        }

        public string ToString()
        {
            string result = String.Empty;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result += this.ValueAtIndexPrograming(i, j).ToString() + " ";
                }
                result += System.Environment.NewLine;
            }
            return result;
        }


    }

    class Program
    {
        
        static void Main(string[] args)
        {
            int[,] A = 
            {
                {1,1},
                {1,1}
            };

            int[,] B = 
            {
                {1,1},
                {1,1}
            };

            Matrix matrixA = new Matrix(A);
            Matrix matrixB = new Matrix(B);

            Console.WriteLine(matrixA.ToString());

            Matrix sum = matrixA + matrixB;
            Console.WriteLine(sum.ToString());

            Console.WriteLine(matrixA.MultiplyByNymber(-1).ToString());
            Matrix sub = matrixA.Subtract(matrixB);
            Console.WriteLine(sub.ToString());

            Matrix mul = matrixA.Multiply(matrixB);

            Console.WriteLine(mul.ToString());

            Console.WriteLine(matrixA[0, 0]);
            matrixA[0, 0] = 100;
            Console.WriteLine(matrixA[0, 0]);
           
        }
    }
}
