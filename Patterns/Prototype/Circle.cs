using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Circle : IFigure, ICloneable
    {
        int radius;
        public Point Point { get; set; }
        public Circle(int r, int x, int y)
        {
            radius = r;
            this.Point = new Point { X = x, Y = y };
        }
        Circle() { radius = 0; Point = null; }
        public object Clone()
        {
            return new Circle()
            {
                radius = this.radius,
                Point = new Point { X = this.Point.X, Y = this.Point.Y }
            };

        }

        IFigure IFigure.Clone()
        {
            Console.WriteLine("do not use ");
            throw new NotImplementedException();
        }

        public void GetInfo()
        {
            Console.WriteLine($"It's circle: {radius}");
        }


    }
}

//[Serializable]
//class Point
//{
//    public int X { get; set; }
//    public int Y { get; set; }
//}
//[Serializable]
//class Circle : IFigure
//{
//    int radius;
//    public Point Point { get; set; }
//    public Circle(int r, int x, int y)
//    {
//        radius = r;
//        this.Point = new Point { X = x, Y = y };
//    }

//    public IFigure Clone()
//    {
//        return this.MemberwiseClone() as IFigure;
//    }

//    public object DeepCopy()
//    {
//        object figure = null;
//        using (MemoryStream tempStream = new MemoryStream())
//        {
//            BinaryFormatter binFormatter = new BinaryFormatter(null,
//                new StreamingContext(StreamingContextStates.Clone));

//            binFormatter.Serialize(tempStream, this);
//            tempStream.Seek(0, SeekOrigin.Begin);

//            figure = binFormatter.Deserialize(tempStream);
//        }
//        return figure;
//    }
//    public void GetInfo()
//    {
//        Console.WriteLine("Круг радиусом {0} и центром в точке ({1}, {2})", radius, Point.X, Point.Y);
//    }
//}
