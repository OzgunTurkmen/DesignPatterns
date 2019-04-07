using System;

namespace _06.Facade
{
    /// <summary>
    /// Amacı kullanılan sınıfların tek bir yerden yönetilmesini sağlamaktır.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            app.Run();
            Console.Read();
        }
    }

    public class Application
    {
        Caching cache = new Caching();
        Logging logging = new Logging();

        public void Run()
        {
            cache.Cache();
            logging.Log();
        }
    }

    public class Caching
    {
        public void Cache()
        {
            Console.WriteLine("Cache");
        }
    }

    public class Logging
    {
        public void Log()
        {
            Console.WriteLine("Log");

        }
    }
}
