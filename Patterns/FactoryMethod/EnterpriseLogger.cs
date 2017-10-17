using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class EnterpriseLogger :ILogger
    {
        public void LogError()
        {
            Console.WriteLine("Error by EnterpriseLogger");
        }

        public void LogMessage()
        {
            Console.WriteLine("Message by EnterpriseLogger");
        }
    }
}
