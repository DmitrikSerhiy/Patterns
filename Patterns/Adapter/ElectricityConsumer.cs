using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ElectricityConsumer
    {
        public static void ChargePhone(INewElectricitySystem newElectricitySystem)
        {
            Console.WriteLine(newElectricitySystem.MatchWideSocket());
        }
    }
}
