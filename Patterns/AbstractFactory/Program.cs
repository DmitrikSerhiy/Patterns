using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IToyFactory softToys = new SoftToyFactory();
            IToyFactory woodenToys = new WoodenToyFactory();

            Bear teddy = softToys.Bear;
            Cat myrzik = woodenToys.Cat;

            teddy.Name = "Teddy";
            myrzik.Name = "myrzik";

            Console.WriteLine($"it's {teddy.Name}");
            Console.WriteLine($"it's {myrzik.Name}");

            Console.ReadKey();
        }
    }
}
