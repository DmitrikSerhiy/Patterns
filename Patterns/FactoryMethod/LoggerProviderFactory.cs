using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class LoggerProviderFactory
    {
        private Dictionary<string, ILogger> logProviders = new Dictionary<string ,ILogger>
        {
            { "Log4Net", new Log4Net() },
            { "EnterpriseLogger", new EnterpriseLogger() }
        };

        public ILogger GetLoggingProvider(string logger)
        {
            return logProviders.ContainsKey(logger) ? logProviders[logger] : null;
        }
    }
}
