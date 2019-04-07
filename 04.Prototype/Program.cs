using System;

namespace _04.Prototype
{
    /// <summary>
    /// Amaç => Nesne üretim maliyetini minimize etmek.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer() { ID = 1, Name = "Özgün", Surname = "Türkmen", CustomerNo = "100" };

            var c2 = (Customer)c.Clone();
            c2.Name = "Bobby";


            Console.WriteLine(c.Name);
            Console.WriteLine(c2.Name);

            Console.Read();


        }
    }

    public abstract class Person
    {
        public abstract Person Clone();
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }


    public class Customer : Person
    {
        public string CustomerNo { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
