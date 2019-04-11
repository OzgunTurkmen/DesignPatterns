using System;

namespace _11.Bridge
{
    /// <summary>
    /// bir nesne içinde soyutlanabilir kısımlar var ise onları soyutlamak olarak düşünülebilir.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Messenger = new SmsSender();

            manager.Update("TEST");

            Console.Read();
        }
    }

    public abstract class MessageManagerBase
    {
        public void Save()
        {

        }

        public abstract void Send(string message);
    }

    public class SmsSender : MessageManagerBase
    {
        public override void Send(string message)
        {
            Console.WriteLine(message);
        }
    }


    public class MailSender : MessageManagerBase
    {
        public override void Send(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Manager
    {
       
        public MessageManagerBase Messenger { get; set; }

        public void Update(string test)
        {
            Messenger.Send(test);
        }
    }
}
