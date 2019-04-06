using System;
using System.Collections.Generic;
using System.Text;

namespace _02.FactoryMethod
{
    public class Log4NetLogger : ILogger
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public Log4NetLogger(string key, string value)
        {
            Key = key;
            Value = value;
        }


        public void Log()
        {
            Console.WriteLine("{0} key was logged with {1} value. Provider is:Log4Net", Key, Value);
        }
    }
}
 