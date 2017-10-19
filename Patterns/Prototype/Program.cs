using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle figure = new Circle(30, 50, 60);
            Circle clonedFigure = figure.Clone() as Circle;

            //---------Example of deep copy
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure.Radius = 1000;

            figure.GetInfo();
            clonedFigure.GetInfo();
            //---------Example of deep copy

            //---------Example of shalow copy 
            //---------But class doesn't contain referense type
            Rectangle rectangle = new Rectangle(20, 40);
            Rectangle clonedRectangle = rectangle.Clone() as Rectangle;

            rectangle.GetInfo();
            clonedRectangle.GetInfo();

            Console.ReadKey();
        }
    }
}
