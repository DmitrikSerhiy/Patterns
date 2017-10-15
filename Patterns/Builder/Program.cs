using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var buyGamingLaptop = new BuyLaptop(new GamingLaptop());
            buyGamingLaptop.BuildLaptop();

            var buySlowLaptop = new BuyLaptop(new SlowLaptop());
            buySlowLaptop.BuildLaptop();

            Laptop lap1 = buyGamingLaptop.GetLaptop();
            Laptop lap2 = buySlowLaptop.GetLaptop();

            Console.WriteLine($"Gaming laptop: {lap1.CPU} {lap1.Battery} {lap1.Memory} {lap1.Monitor}");
            Console.WriteLine($"Slow laptop: {lap2.CPU} {lap2.Battery} {lap2.Memory} {lap2.Monitor}");
            Console.ReadKey();
        }
    }
}
