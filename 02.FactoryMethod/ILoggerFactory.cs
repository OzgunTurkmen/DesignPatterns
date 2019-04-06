namespace _02.FactoryMethod
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger(string key,string value);
    }
}