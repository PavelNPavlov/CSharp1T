using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWClasses2.Models
{
    public static class Distance
    {
        public static double GetDistance(Point3D a, Point3D b)
        {
            double result;
            result = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2) + Math.Pow(a.Y - b.Y, 2));
            return result;
        }
    }
}
