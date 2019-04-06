using System;

namespace _01.Singleton
{

    /// <summary>
    /// Singleton pattern'de hedef üretilen nesnenin tek olmasının garanti edilmesidir.Böylelikle instance ile üretilen değer her defasında sıfırlanmaz. Singleton nesne null'a çekilmediği sürece ram'de kalır. Sürekli yapılan işlemler singleton olarak tasarlanabilir.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            var customerManager=CustomerManager.CreateAsSingleton();
            customerManager.Save("Özgün");

            Console.Read();
        }
    }

    class CustomerManager
    {
        private static CustomerManager _customerManager;

        //dışarıdan erişilmesini engellemek için constructor private yapılır. böylelikle sınıf sürekli new'lenemez.
        //CreateAsSingleton() ile nesneyi üretmiş oluruz.
        private CustomerManager()
        {

        }

        public static CustomerManager CreateAsSingleton()
        {
            if (_customerManager==null)
            {
                _customerManager = new CustomerManager();
            }

            return _customerManager;
        }

        public void Save(string customerName)
        {
            Console.WriteLine(customerName+" Saved!");
        }
    }

    
}
