using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class LoggerSingleton
    {
        private string LogName;
        private LoggerSingleton(string _LogName) { LogName = _LogName; }
        private static LoggerSingleton instance = null;
        public static LoggerSingleton GetInstance()
        {
            if(instance == null)
            {
                instance = new LoggerSingleton("First and single instance of Logger class");
            }
            return instance;
        }

        public void GetInfo()
        {
            Console.WriteLine(LogName);
        }
    }
}
