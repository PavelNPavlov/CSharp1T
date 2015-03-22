using HWClasses2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWClasses2
{
    class Point3DTest
    {
        static void Main(string[] args)
        {
            Point3D a = new Point3D(1, 1, 1);
            Point3D b = new Point3D(1, 1, 1);

            Path x = new Path();

            x.PathPoints.Add(a);
            x.PathPoints.Add(b);

            PathStorage.WriteToFile(x);

            Path y = PathStorage.ReadFromFile("Storage.txt");
            Console.WriteLine(Distance.GetDistance(a,b));
        }
    }
}
