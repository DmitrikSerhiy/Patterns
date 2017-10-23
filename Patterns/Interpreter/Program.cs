using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mercedec");
            Car car2 = new Car("Volvo");
            Car car3 = new Car("Nisan");
            Car car4 = new Car("Opel");

            Garage garage = new Garage(4);
            garage.MoveCarToGarage(car1);
            garage.MoveCarToGarage(car2);
            garage.MoveCarToGarage(car3);
            garage.MoveCarToGarage(car4);

            Console.WriteLine("Cars: ");
            foreach (Car item in garage)
            {
                Console.WriteLine(item._Name);
            }

            Console.ReadKey();
        }
    }
}
