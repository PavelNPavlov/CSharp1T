using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{

    [AttributeUsage(AttributeTargets.Struct |
    AttributeTargets.Class | AttributeTargets.Interface,
    AllowMultiple = true)]
    public class VersionAttribute : System.Attribute
    {
        public string Object { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }

        public VersionAttribute(int n, int m, string o )
        {
            this.Object = o;
            this.MajorVersion = n;
            this.MinorVersion = m;

        }

        public override string ToString()
        {
            return string.Format("{0} - v.{1}.{1}", this.Object, this.MajorVersion, this.MinorVersion);
        }
    }

    [Version(1,1,"Matrix Class")]
    
    class MatrixAndAttributeTest
    {

        static void Main(string[] args)
        {
            Type type = typeof(MatrixAndAttributeTest);
            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute item in allAttributes)
            {
                Console.WriteLine(item);
            }

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
