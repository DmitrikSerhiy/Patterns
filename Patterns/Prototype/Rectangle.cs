using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Rectangle : IFigure
    {
        public int width { get; set; }
        public int height { get; set; }
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public IFigure Clone()// simple copy
        {
            return this.MemberwiseClone() as IFigure;
        }

        public void GetInfo()
        {
            Console.WriteLine($"It's rectangle: {height}, {width}");
        }
    }
}
