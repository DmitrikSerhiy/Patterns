using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerSingleton logger = LoggerSingleton.GetInstance();
            logger.GetInfo();

            LoggerSingleton logger2 = LoggerSingleton.GetInstance(); //it's the same instance of logger
            Console.WriteLine(logger.Equals(logger2));
            Console.ReadKey();
        }
    }
}
