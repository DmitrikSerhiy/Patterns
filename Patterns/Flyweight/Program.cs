using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> Units = new List<Unit>();
            for (int i = 0; i < 100; i++)
            {
                Units.Add(new Dragon());
            }
            for (int i = 0; i < 1000; i++)
            {
                Units.Add(new Goblin());
            }
            Console.WriteLine(Units.Count);
            Console.WriteLine($"number of loads: {Image.LoadCount}");
            Console.ReadKey();
        }
    }
}
