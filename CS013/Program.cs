using System;

namespace CS013
{
    class Animal
    {
        public int Leg { get; set; }
        public string Weight { get; set; }

        public void showLegs()
        {
            Console.WriteLine($"Legs: {Leg}");
        }
    }

    class Cat : Animal
    {
        public string Food { get; set; }
        public Cat()
        {
            this.Leg = 4;
            this.Weight = "12kg";
            this.Food = "Com voi ca chu hok hun ma ai dou";
        }
        public void eat()
        {
            Console.WriteLine($"Eat: {Food}");
        }

        public override string ToString()
        {
            return $"Con meo nay co {Leg} chan, nang {Weight} va an {Food}";
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            Cat cat1 = new Cat();

            Console.WriteLine(cat1.ToString());

        }
    }
}
