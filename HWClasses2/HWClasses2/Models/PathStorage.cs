using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HWClasses2.Models
{
    public static class PathStorage
    {
        //Path Internal = new Path();

        public static void WriteToFile(Path a)
        {
            List<string> temp = new List<string>();

            foreach (var item in a.PathPoints)
            {
                temp.Add(string.Format("{0} {1} {2}", item.X, item.Y, item.Z));
            }

            File.WriteAllLines("Storage.txt", temp.ToArray());
        }

        public static Path ReadFromFile(string s)
        {
            Path temp = new Path();

            string[] data = File.ReadAllLines(s);

            foreach (var item in data)
            {
                string[] tempData = item.Split(' ');

                temp.PathPoints.Add(new Point3D(double.Parse(tempData[0]), double.Parse(tempData[1]), double.Parse(tempData[2])));
            }

            return temp;
        }
    }
}
