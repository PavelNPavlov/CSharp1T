using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWClasses2.Models
{
    public struct Point3D
    {
        public static Point3D origing=new Point3D(0, 0, 0);

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D (double x, double y, double z): this()
	    {
            this.X = x;
            this.Y = y;
            this.Z = z;
	    }

        public override string ToString()
        {
            return string.Format("{ {0},{1},{2} }", this.X, this.Y, this.Z);
        }
    }
}
