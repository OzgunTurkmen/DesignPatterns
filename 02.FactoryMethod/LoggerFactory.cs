using System;
using System.Collections.Generic;
using System.Text;

namespace _02.FactoryMethod
{
    public class LoggerFactory:ILoggerFactory
    {
        public ILogger CreateLogger(string key, string value)
        {
            return new Log4NetLogger(key,value);
        }
    } 
}
