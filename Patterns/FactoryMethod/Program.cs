using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerProviderFactory loggerProviderFactory = new LoggerProviderFactory();
            var logger1 = loggerProviderFactory.GetLoggingProvider("Log4Net");
            var logger2 = loggerProviderFactory.GetLoggingProvider("EnterpriseLogger");

            logger1.LogMessage();
            logger1.LogError();

            logger2.LogMessage();
            logger2.LogError();

            Console.ReadKey();
        }
    }
}
