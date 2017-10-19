using System;

namespace Prototype
{
    public class Circle : IFigure
    {
        public int Radius { set; get; }
        private Point Point;

        public Circle(int _Radius, int X, int Y)
        {
            Radius = _Radius;
            Point = new Point(X, Y);
        }
        public void GetInfo()
        {
            Console.WriteLine($"It's circle! Radius: {Radius} X: {this.Point.X} Y: {this.Point.Y}");
        }

        public IFigure Clone()
        {
            int newX = this.Point.X;
            int newY = this.Point.Y;
            Point newPoint = new Point(newX, newY);// { X = this.Point.X, Y = this.Point.Y };
            return new Circle(this.Radius, newPoint.X, newPoint.Y) as IFigure;  
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
