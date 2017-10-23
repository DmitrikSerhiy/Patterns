using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("Some image");
            image.Display();//download is commited only once
            image.Display();
            Console.ReadKey();
        }
    }
}
