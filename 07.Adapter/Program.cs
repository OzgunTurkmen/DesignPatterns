using System;

namespace _07.Adapter
{
    /// <summary>
    /// farklı sistemlerin kendi sistemimize entegre edilirken bizim sistemimizi bozmamasını sağlamak esas amacıdır.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new OzgunLogger();
            logger.Log("Test");
            Console.Read();

        }
    }

    public interface ILogger
    {
        void Log(string Message);
    }

    public class OzgunLogger : ILogger
    {
        public void Log(string Message)
        {
            Console.WriteLine("Log with message {0} ozgun loggger ",Message);
        }
    }

    public class Log4Net
    {
        public void LogMessage(string Message)
        {
            Console.WriteLine("Log with message {0} Log4Net loggger ", Message);
        }
    }

    public class Log4NetAdapter : ILogger
    {
        Log4Net Log4Net = new Log4Net();

        public void Log(string Message)
        {
            Log4Net.LogMessage(Message);
        }
    }


}
