using System;

namespace _10.Decorator
{

    /// <summary>
    /// temel nesnenin farklı koşullarda farklı anlamlar yüklemek için kullanılır.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var personelCar = new PersonalCar { Marka = "BMW", Model = "2015", KiraUcreti = 100 };

            SpecialOffer specialOffer = new SpecialOffer(personelCar);

            specialOffer.IndirimOrani = 10;

            Console.WriteLine(personelCar.KiraUcreti);
            Console.WriteLine(specialOffer.KiraUcreti);


            Console.Read();
        }
    }

    //Temel nesne
    public abstract class CarBase
    {
        public abstract string Marka { get; set; }
        public abstract string Model { get; set; }
        public abstract decimal KiraUcreti { get; set; }
    }

    public class PersonalCar : CarBase
    {
        public override string Marka { get; set; }
        public override string Model { get; set; }
        public override decimal KiraUcreti { get; set; }
    }

    public class CommercialCar : CarBase
    {
        public override string Marka { get; set; }
        public override string Model { get; set; }
        public override decimal KiraUcreti { get; set; }
    }


    public abstract class CarDecaratorBase : CarBase
    {
        protected CarBase _carbase;

        public CarDecaratorBase(CarBase carbase)
        {
            _carbase = carbase;
        }
    }

    public class SpecialOffer : CarDecaratorBase
    {
        public decimal IndirimOrani { get; set; }

        public SpecialOffer(CarBase carbase) : base(carbase)
        {
        }

        public override string Marka { get; set; }
        public override string Model { get; set; }

        private decimal kiraUcreti;

        public override decimal KiraUcreti
        {
            get
            {
                return _carbase.KiraUcreti * (100- IndirimOrani)/100;
            }
            set
            {
                kiraUcreti = value;
            }
        }

    }


}
