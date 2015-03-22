using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWClasses2.Models
{
    public class Path
    {
        public List<Point3D> PathPoints { get; set; }

        public Path()
        {
            this.PathPoints = new List<Point3D>();
        }
    }
}
