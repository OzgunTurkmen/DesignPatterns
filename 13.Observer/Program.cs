using System;
using System.Collections.Generic;

namespace _13.Observer
{
    /// <summary>
    /// kendisine abone olan bir sınıfta değişiklik olduğu zaman subscribelerlara haber verilmesi durumu.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Manager
    {
        List<Observer> observers = new List<Observer>();

        public void UpdatePrice()
        {
            Console.WriteLine("Fiyat değişti.");
            Notify();
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        private void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }

    public abstract class Observer
    {
        public abstract void Update();
    }

    public class CustomerObserver : Observer
    {
        public override void Update()
        {
        }
    }

    public class EmployeeObserver : Observer
    {
        public override void Update()
        {
        }
    }
}
