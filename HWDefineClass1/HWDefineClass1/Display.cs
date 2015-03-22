using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWDefineClass1
{
    struct Size
    {
        private double x;
        private double y;
        public double X { get; set; }
        public double Y { get; set; }

        public Size(double h, double w):this()
        {
            this.X = w;
            x = w;
            this.Y = h;
            y = h;
        }
        public override string ToString()
        {
            string s = string.Format("{0}cm  {1}cm", x, y);
            return s;
        }
    }
    class Display
    {
        public Size ScreenSize { get; set; }
        public int NumberOfColors { get; set; }

        public Display(Size h=new Size(),int n=0)
        {
            this.ScreenSize = h;
            this.NumberOfColors = n;
        }

        public override string ToString()
        {
            string s = string.Format("Dimentions: {0}\nNumberOfColors: {1}", this.ScreenSize, this.NumberOfColors);
            return s;
        }


    }
}
