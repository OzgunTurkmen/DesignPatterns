using System;

namespace _03.AbstractFactory
{
    /// <summary>
    /// Factory methodun toplu kullanımı olarak düşünülebilir.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //if if if yazmaktansa sadece factory'i seçiyoruz olay bitiyor. temiz iş.
            Factory1 f1 = new Factory1();

            Logging logger =f1.CreateLogger();
            logger.Log("Message");

            Caching cacher = f1.CreateCaching();
            cacher.Cache("test");
        }
    }

    public abstract class Logging
    {
        public abstract void Log(string Message);
    }

    public abstract class Caching
    {
        public abstract void Cache(object data);
    }

    public abstract class CrossCuttingConcernFactory
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCaching();
    }

    public class Factory1 : CrossCuttingConcernFactory
    {
        public override Caching CreateCaching()
        {
            throw new NotImplementedException();
        }

        public override Logging CreateLogger()
        {
            throw new NotImplementedException();
        }
    }

    public class Factory2 : CrossCuttingConcernFactory
    {
        public override Caching CreateCaching()
        {
            throw new NotImplementedException();
        }

        public override Logging CreateLogger()
        {
            throw new NotImplementedException();
        }
    }


}
