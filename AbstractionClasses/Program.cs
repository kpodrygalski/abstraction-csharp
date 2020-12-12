using System;

namespace AbstractionClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Figura f = new Figura();
            Square square = new Square(10.0);

            Console.WriteLine(square.ObliczPole());
        }
    }
}
