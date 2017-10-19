using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mercedec = new Mercedes(); //simple Car
            PoliceCar policeCar = new PoliceCar(mercedec); //it's decorated Car - PoliceCar

            mercedec.Drive();
            policeCar.Drive();

            Console.ReadKey();
        }
    }
}
