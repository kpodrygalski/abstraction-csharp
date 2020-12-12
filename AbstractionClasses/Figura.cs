using System;
namespace AbstractionClasses
{
    public abstract class Figura
    {
        public Figura()
        {
            Console.WriteLine("FIGURA CONSTRUCTOR");
        }

        public abstract double ObliczPole();
    }
}
