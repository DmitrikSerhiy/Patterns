using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var newElectricitySystem = new NewElectricitySystem();
            var oldElectricitySystem = new OldElecticitySystem();

            ElectricityConsumer.ChargePhone(newElectricitySystem);

            var adapter = new Adaprer(oldElectricitySystem);
            ElectricityConsumer.ChargePhone(adapter);
            Console.ReadKey();
        }
    }
}
