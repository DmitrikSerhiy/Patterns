using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Log4Net : ILogger
    {
        public void LogError()
        {
            Console.WriteLine("Error by Log4Net");
        }

        public void LogMessage()
        {
            Console.WriteLine("Message by Log4Net");
        }
    }
}
