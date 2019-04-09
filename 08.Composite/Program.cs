using System;
using System.Collections;
using System.Collections.Generic;

namespace _08.Composite
{
    /// <summary>
    /// nesneler arası hiyerarşiyi kurgulamak için kullanılır.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Employee özgün = new Employee { Name = "Özgün Türkmen" };

            Employee ulaş = new Employee { Name = "Ulaş Acar" };

            özgün.AddSubordinate(ulaş);

            Employee evrim = new Employee { Name = "Evrim Türkmen" };

            özgün.AddSubordinate(evrim);

            Employee murat = new Employee { Name = "Murat Acar" };

            evrim.AddSubordinate(murat);

            foreach (Employee manager in özgün)
            {
                Console.WriteLine(manager.Name);

                foreach (Employee employee in manager)
                {
                    Console.WriteLine(employee.Name);
                }
            }


            Console.Read();
        }
    }

    public interface IPerson
    {
        string Name { get; set; }
    }

    public class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> subordinartes = new List<IPerson>();

        public void AddSubordinate(IPerson person)
        {
            subordinartes.Add(person);
        }

        public void RemoveSubordinate(IPerson person)
        {
            subordinartes.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return subordinartes[index];
        }

        public string Name { get; set; }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinarte in subordinartes)
            {
                yield return subordinarte;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
