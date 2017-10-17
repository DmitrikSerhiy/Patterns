using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface ILogger
    {
        void LogMessage();
        void LogError();
    }
}
