using System;

namespace _12.Strategy
{
    /// <summary>
    /// if if yazmak yerine sınıfın çağrılmasıyla concrete edilir.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ILanguageStrategy lang = new Turkish();
            Console.WriteLine(lang.MissionCompleted());
            
            lang = new English();
            Console.WriteLine(lang.MissionCompleted());

            Console.Read();
        }
    }

    public interface ILanguageStrategy
    {
        string MissionCompleted();
    }

    public class Turkish : ILanguageStrategy
    {
        public string MissionCompleted()
        {
            return "Görev tamam";
        }
    }

    public class English : ILanguageStrategy
    {
        public string MissionCompleted()
        {
            return "Mission completed";
        }
    }
}
