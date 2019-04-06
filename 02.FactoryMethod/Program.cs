using System;

namespace _02.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerService service = new CustomerManager(new LoggerFactory());

            service.Save("TESTKEY", "TESTVALUE");

            Console.Read();
        }
    }

    public class CustomerManager : ICustomerService
    {
        ILoggerFactory _loggerFactory;

        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public void Save(string key, string value)
        {
            _loggerFactory.CreateLogger(key,value).Log();
        }
    }

    public interface ICustomerService
    {
        void Save(string key, string value);
    }
}
