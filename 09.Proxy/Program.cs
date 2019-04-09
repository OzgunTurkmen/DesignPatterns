using System;
using System.Threading;

namespace _09.Proxy
{

    /// <summary>
    /// Cacheleme işlemi gibi düşünülebilir.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CreditBase manager = new CreditManagerProxy();
            Console.WriteLine(manager.Calculate().ToString());
            Console.WriteLine(manager.Calculate().ToString());

            Console.Read();

        }
    }

    public abstract class CreditBase
    {
        public abstract int Calculate();
    }

    public class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int res = 1;

            for (int i = 1; i < 10; i++)
            {
                res += i;
            }

            Thread.Sleep(3000);

            return res;
        }
    }

    public class CreditManagerProxy : CreditBase
    {
        CreditManager creditManager;
        int cachedValue;

        public override int Calculate()
        {
            if (creditManager != null)
            {
                return cachedValue;
            }

            creditManager = new CreditManager();
            cachedValue = creditManager.Calculate();

            return cachedValue;
        }
    }


}
